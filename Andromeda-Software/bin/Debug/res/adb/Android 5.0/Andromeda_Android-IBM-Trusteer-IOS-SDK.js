if (ObjC.available)
{
  try {

    const Tas = ObjC.classes.Tas;

    //
    // The TasDraGetRiskItem count is the key function to hook as it returns the number of "risk factors" for an app.
    // If there are no risk factors, welp ;).
    //
    // Reference: http://public.dhe.ibm.com/partnerworld/pub/certify/ibm_security_trusteer_mobile_sdk_developers_guide_ios.pdf
    const TasDraGetRiskItemCount = Tas['- TasDraGetRiskItemCount:'];
    TasDraGetRiskItemCount.implementation = ObjC.implement(TasDraGetRiskItemCount, function(handle, selector, arg1) {
      console.log(`Called TasDraGetRiskItemCount`);
      arg1 = 0;
      return 0;
    })

  } catch(err) {
    console.log("[!] Exception while hooking: " + err.message);
  } 
} else {
  console.log("Objective-C Runtime is not available!");
}