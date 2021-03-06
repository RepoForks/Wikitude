using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.
using MonoTouch.ObjCRuntime;


[assembly: AssemblyTitle ("Wikitude")]
[assembly: AssemblyDescription ("Wikitude SDK for Xamarin.iOS")]
[assembly: AssemblyConfiguration ("")]
[assembly: AssemblyCompany ("Wikitude")]
[assembly: AssemblyProduct ("")]
[assembly: AssemblyCopyright ("")]
[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]
// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.
[assembly: AssemblyVersion ("1.0.*")]
// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.
//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

[assembly: LinkWith ("WikitudeSDK.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, LinkerFlags = "-ObjC -lstdc++ -dead_strip -lz -lsqlite3", IsCxx = true, 
    Frameworks = "Foundation UIKit Accounts Social AssetsLibrary CFNetwork CoreGraphics AVFoundation CoreLocation CoreMedia CoreMotion " +
    "CoreVideo MediaPlayer OpenGLES QuartzCore Security SystemConfiguration")]
