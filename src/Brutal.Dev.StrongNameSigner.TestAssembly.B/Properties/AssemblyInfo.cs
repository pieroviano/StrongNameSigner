using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3716c257-9552-44c9-98ea-e38bd3252943")]

[assembly: InternalsVisibleTo("Brutal.Dev.StrongNameSigner.TestAssembly.A")]
[assembly: InternalsVisibleTo("ThisMustGetRemoved")]
[assembly: InternalsVisibleTo("ThisMustGetRemovedAsWell")]
