/**
 * Modify iOS Function
 * 
 * Created by avltree9798
 * 
 * For example
 * modify_implementation("JailbreakDetection", "- isJailbroken", function(){
 * return false;
 * });
 * 
 * */
 
 function modify_implementation(class_name, method_name, functions) {
    try {
        console.error("- [" + class_name + " " + method_name + "] hooked");
        var methodObj = ObjC.classes[class_name][method_name]
        var old_implementation = methodObj.implementation;
        methodObj.implementation = ObjC.implement(methodObj, functions);
    } catch (err) {
        console.log('[!] Error while hooking ' + class_name + ' [' + method_name + ']', err);
    }
}