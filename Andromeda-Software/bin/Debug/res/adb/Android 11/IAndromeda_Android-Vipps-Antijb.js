'use strict';

var method = ObjC.classes.VPSUtils['+ isJailbroken'];
method.implementation = ObjC.implement(method, function (handle, selector) {
  console.log('+[VPSUtils isJailbroken] => nope!');
  return false;
});