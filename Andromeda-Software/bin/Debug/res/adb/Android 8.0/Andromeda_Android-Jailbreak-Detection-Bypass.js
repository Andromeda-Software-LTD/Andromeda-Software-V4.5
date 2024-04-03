if (ObjC.available) {
    var paths = [
        "/Applications/blackra1n.app",
        "/Applications/Cydia.app",
        "/Applications/FakeCarrier.app",
        "/Applications/Icy.app",
        "/Applications/IntelliScreen.app",
        "/Applications/MxTube.app",
        "/Applications/RockApp.app",
        "/Applications/SBSetttings.app",
        "/Applications/WinterBoard.app",
        "/bin/bash",
        "/bin/sh",
        "/bin/su",
        "/etc/apt",
        "/etc/ssh/sshd_config",
        "/Library/MobileSubstrate/DynamicLibraries/LiveClock.plist",
        "/Library/MobileSubstrate/DynamicLibraries/Veency.plist",
        "/Library/MobileSubstrate/MobileSubstrate.dylib",
        "/pguntether",
        "/private/var/lib/cydia",
        "/private/var/mobile/Library/SBSettings/Themes",
        "/private/var/stash",
        "/private/var/tmp/cydia.log",
        "/System/Library/LaunchDaemons/com.ikey.bbot.plist",
        "/System/Library/LaunchDaemons/com.saurik.Cydia.Startup.plist",
        "/usr/bin/cycript",
        "/usr/bin/ssh",
        "/usr/bin/sshd",
        "/usr/libexec/sftp-server",
        "/usr/libexec/ssh-keysign",
        "/usr/sbin/frida-server",
        "/usr/sbin/sshd",
        "/var/cache/apt",
        "/var/lib/cydia",
        "/var/log/syslog",
        "/var/mobile/Media/.evasi0n7_installed",
        "/var/tmp/cydia.log"
    ];
    var f = Module.findExportByName("libSystem.B.dylib", "stat64");
    Interceptor.attach(f, {
        onEnter: function(args) {
            this.is_common_path = false;
            var arg = Memory.readUtf8String(args[0]);
            for (var path in paths) {
                if (arg.indexOf(paths[path]) > -1) {
                    console.log("Hooking native function stat64: " + arg);
                    this.is_common_path = true;
                    //return -1;
                }
            }
        },
        onLeave: function(retval) {
            if (this.is_common_path) {
                console.log("stat64 Bypass!!!");
                retval.replace(-1);
            }
        }
    });
    var f = Module.findExportByName("libSystem.B.dylib", "stat");
    Interceptor.attach(f, {
        onEnter: function(args) {
            this.is_common_path = false;
            var arg = Memory.readUtf8String(args[0]);
            for (var path in paths) {
                if (arg.indexOf(paths[path]) > -1) {
                    console.log("Hooking native function stat: " + arg);
                    this.is_common_path = true;
                    //return -1;
                }
            }
        },
        onLeave: function(retval) {
            if (this.is_common_path) {
                console.log("stat Bypass!!!");
                retval.replace(-1);
            }
        }
    });
}