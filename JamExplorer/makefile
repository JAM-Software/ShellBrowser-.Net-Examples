###################
# makefile targets
#
JAMEXPLORER=.\bin\release\JamExplorer.exe


full: $(JAMEXPLORER)

#########################

RESGEN=resgen.exe
#C:\Programme\Microsoft.NET\SDK\v2.0\Bin\resgen.exe
CSC=c:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\csc.exe

#CSC=c:\WINDOWS\Microsoft.NET\Framework\v1.1.4322\csc.exe
#CSC=csc.exe
#CSC=C:\Programme\Mono-1.2.2.1\bin\mcs.bat

#signing batch file 
SIGN_TOOL=Call Sign.bat

### resx:
RESOURCE=bin\res\Jam.Shell.Properties.Resource.resources

clean:
   @echo [[[[[[[[[       Building JamExplorer        ]]]]]]]]]
   @echo Cleaning up...
   -del $(JAMEXPLORER) 2>NUL

#################################################
#   BUILD .DLL                                                                                                               
#################################################

### the default files to be build into the assembly
CS_FILES=JamExplorerMain.cs JamExplorerMain.Designer.cs Program.cs Settings.cs Resource1.Designer.cs Properties\AssemblyInfo.cs Properties\Settings.Designer.cs
# Properties\Resource.Designer.cs

LINKRES=/res:bin\res\Jam.Shell.Resource1.arrow_green_left_24.bmp /res:bin\res\Jam.Shell.Resource1.arrow_green_right_24_h.bmp /res:bin\res\Jam.Shell.Resource1.New_folder_16.bmp /res:bin\res\Jam.Shell.Resource1.tree_24_h.bmp /res:bin\res\Jam.Shell.Resource1.tree24.bmp /res:bin\res\Jam.Shell.Resource1.up_folder24_h.bmp /res:bin\res\Jam.Shell.Resource1.views24.bmp /res:bin\res\Jam.Shell.Resource1.views24_d.bmp  /res:bin\res\Jam.Shell.Resource1.views24_h.bmp

### referenced assemblies
REFERENCED_ASSEMBLIES=System.dll,System.Data.dll,System.Deployment.dll,System.Drawing.dll,System.Windows.Forms.Dll,System.Xml.dll,..\..\bin\protect\ReleaseDemo\ShellBrowser.dll
#,$(JAM_UTILS)
#Configuration.Install.dll,System.Data.dll,System.Drawing.dll,System.Management.dll,System.Windows.Forms.dll,System.Xml.dll,mscorlib.dll
### the public/private keypair to sign the assembly
KEYFILE=ShellBrowser.pfx
KEYCONTAINER=ShellBrowser

# this copies the picture resources to bin\res, then runs the RESOURCE COMPILER $(RESGEN)
$(RESOURCE): makefile
  -@echo generating resources
  -@mkdir bin\res 2>NUL
  -copy /Y Resources\arrow_green_left_24.bmp bin\res\Jam.Shell.Resource1.arrow_green_left_24.bmp
  -copy /Y Resources\arrow_green_right_24_h.bmp bin\res\Jam.Shell.Resource1.arrow_green_right_24_h.bmp
  -copy /Y Resources\New_folder_16.bmp bin\res\Jam.Shell.Resource1.New_folder_16.bmp
  -copy /Y Resources\tree_24_h.bmp bin\res\Jam.Shell.Resource1.tree_24_h.bmp
  -copy /Y Resources\tree24.bmp bin\res\Jam.Shell.Resource1.tree24.bmp
  -copy /Y Resources\up_folder24_h.bmp bin\res\Jam.Shell.Resource1.up_folder24_h.bmp
  -copy /Y Resources\views24.bmp bin\res\Jam.Shell.Resource1.views24.bmp
  -copy /Y Resources\views24_d.bmp bin\res\Jam.Shell.Resource1.views24_d.bmp
  -copy /Y Resources\views24_h.bmp bin\res\Jam.Shell.Resource1.views24_h.bmp
  -$(RESGEN) /compile Resource1.resx,"$(RESOURCE)"

JamExplorer : $(JAMEXPLORER)
  
$(JAMEXPLORER): $(CS_FILES) $(RESOURCE) makefile
  -@mkdir.\bin\Release 2>NUL
  -$(CSC) /define:TRACE /debug:pdbonly /out:$(JAMEXPLORER) /optimize+ /target:winexe $(CS_FILES) /resource:$(RESOURCE) /r:$(REFERENCED_ASSEMBLIES)
  @echo [[[[[[[[[ JamExplorer Build finished ]]]]]]]]]

