﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="WildGums">
//   Copyright (c) 2008 - 2014 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


// All other assembly info is defined in SharedAssembly.cs
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Markup;

[assembly: AssemblyTitle("Orchestra.Core")]
[assembly: AssemblyProduct("Orchestra.Core")]
[assembly: AssemblyDescription("Orchestra core library")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

[assembly: XmlnsPrefix(Orchestra.OrchestraEnvironment.OrchestraUrl, "orchestra")]
[assembly: XmlnsDefinition(Orchestra.OrchestraEnvironment.OrchestraUrl, "Orchestra.Behaviors")]
[assembly: XmlnsDefinition(Orchestra.OrchestraEnvironment.OrchestraUrl, "Orchestra.Converters")]
[assembly: XmlnsDefinition(Orchestra.OrchestraEnvironment.OrchestraUrl, "Orchestra.Controls")]
[assembly: XmlnsDefinition(Orchestra.OrchestraEnvironment.OrchestraUrl, "Orchestra.Markup")]
[assembly: XmlnsDefinition(Orchestra.OrchestraEnvironment.OrchestraUrl, "Orchestra.Views")]
[assembly: XmlnsDefinition(Orchestra.OrchestraEnvironment.OrchestraUrl, "Orchestra.Windows")]