using System;
using Clean_BaseLib;
using MDS_CoreLib;
using MDS_CodeGeneration;
using MDS_ProductConnection;
using MDS_ProductSimulation;


namespace MDS_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ModuleExecutionSystem_MDS                       moduleExeSys;
            UserModule_STD_IO                               stdIOModule;
            MDS_CodeGenModule                               codeGenModule;

            try
            {
                moduleExeSys = new ModuleExecutionSystem_MDS();

                stdIOModule = new UserModule_STD_IO(moduleExeSys);
                codeGenModule = new MDS_CodeGenModule(moduleExeSys);

                moduleExeSys.Execute();
            }
            catch (Exception e)
            {
                ModuleExecutionSystem_MDS.ApplicationExceptionHandler(e);
            }            
        }
    }
}
