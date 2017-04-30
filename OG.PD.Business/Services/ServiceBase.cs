using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OG.PD.Business.Services
{
    public abstract class ServiceBase
    {
        /// <summary>
        /// The common part of the error handling code.
        /// </summary>
        /// <typeparam name="T">The type to return</typeparam>
        /// <param name="codetoExecute">Code to be executed</param>
        /// <returns></returns>
        protected T CallMethod<T>(Func<T> codetoExecute)
        {
            try
            {
                return codetoExecute.Invoke();
            }
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        protected void CallMethod(Action codetoExecute)
        {
            try
            {
                codetoExecute.Invoke();
            }
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

    }
}
