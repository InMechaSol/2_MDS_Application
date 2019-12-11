using System;

namespace MDS_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ModuleExecutionSystem_MDS                       moduleExeSys;
            UserModule_STD_IO                               stdIOModule;
            MDS_CodeGeneration.MDS_CodeGenModule            codeGenModule;

            try
            {
                moduleExeSys =          new ModuleExecutionSystem_MDS();
                stdIOModule =           new UserModule_STD_IO(moduleExeSys);
                codeGenModule =         new MDS_CodeGeneration.MDS_CodeGenModule(moduleExeSys);

                moduleExeSys.Execute();
            }
            catch(Exception e)
            {
                ModuleExecutionSystem_MDS.ApplicationExceptionHandler(e);
            }
            finally 
            {
                ModuleExecutionSystem_MDS.ApplicationClose();
            }                  
        }
    }
}
