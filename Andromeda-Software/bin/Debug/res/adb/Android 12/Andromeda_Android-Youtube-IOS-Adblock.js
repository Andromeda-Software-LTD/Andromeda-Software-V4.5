'use strict';

Module.ensureInitialized('Module_Framework');

var isMonetized = ObjC.classes.YTIPlayerResponse['- isMonetized'];
isMonetized.implementation = ObjC.implement(isMonetized, function () {
  return false;
});