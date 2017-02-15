using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using NLog;

namespace Totosinho.Infra.CrossCutting.Helper
{
    public static class LogHelper
    {
        public static void Fatal(string ServidorCnpj)
        {
            var logger = LogManager.GetCurrentClassLogger();
            try
            {
                AppDomain.CurrentDomain.FirstChanceException += (s, e) =>
                {
                    var log = LogManager.GetCurrentClassLogger();
                    var theEvent = new LogEventInfo(LogLevel.Fatal, "", e.Exception.Message);
                    theEvent.Properties["name"] = ServidorCnpj != null ? " - CNPJ:" + ServidorCnpj : "";
                    log.Log(theEvent);
                };
            }
            catch (Exception e)
            {
                logger.Fatal(e, ServidorCnpj);
            }
        }

        public static void Fatal(Exception e, object ob, string url, string ServidorCnpj)
        {
            var log = LogManager.GetCurrentClassLogger();
            var theEvent = new LogEventInfo(LogLevel.Fatal, "", e.Message);
            theEvent.Properties["name"] = PegaClasseObjeto(ob) + (ServidorCnpj != null ? " - CNPJ:" + ServidorCnpj : "");
            theEvent.Properties["argumentos"] = JsonConvert.SerializeObject(ob) + ",\"url:\" " + url;
            theEvent.Properties["exception"] = JsonConvert.SerializeObject(e);

            theEvent.Exception = e;
            log.Log(theEvent);
        }

        public static void Erro(object obj, string message, string ServidorCnpj)
        {
            var log = LogManager.GetCurrentClassLogger();
            var theEvent = new LogEventInfo(LogLevel.Error, "", message);
            theEvent.Properties["name"] = PegaClasseObjeto(obj);
            theEvent.Properties["objeto"] = JsonConvert.SerializeObject(obj);
            theEvent.Properties["cnpj"] = ServidorCnpj;

            log.Log(theEvent);
        }


        public static void Info(object obj, string ServidorCnpj)
        {
            var theEvent = new LogEventInfo(LogLevel.Info, "", JsonConvert.SerializeObject(obj));
            theEvent.Properties["name"] = PegaClasseObjeto(obj);
            theEvent.Properties["cnpj"] = ServidorCnpj;
            var logger = LogManager.GetCurrentClassLogger();
            try
            {
                logger.Log(theEvent);
            }
            catch (Exception e)
            {
                logger.Fatal(e, ServidorCnpj);
            }
        }

        private static string PegaClasseObjeto(object ob)
        {
            var objClass = ob.GetType().ToString().Split('.').Last();
            if (objClass.Equals("Object]"))
                objClass = ((Dictionary<string, object>) ob).Values.First().ToString().Split('.').Last();
            return objClass;
        }
    }
}