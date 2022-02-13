using System;
using System.Collections.Generic;
using System.Text;


namespace Dllplugin
{
    class UserDll
    {

        /// <summary>
        /// 只要返回不是 down error 程序将自动将结果写入文本中。如果想要自己实现 写文件那么需要返回结果加入|5a75574b96ce583b250cdcfff48caa78
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string DllExec(string url)
        { //方法名称

            string expResult = string.Empty;
            string errorcase = "error";


            string thinkphpRceRes = thinkphpRce(url);



            if (errorcase.Equals(thinkphpRceRes))
            {

                expResult = errorcase;

            }
            else
            {

                expResult = thinkphpRceRes; //系统系统写结果

                expResult = thinkphpRceRes + "|5a75574b96ce583b250cdcfff48caa78|"; //用户自己写成功结果系统不管 标志5a75574b96ce583b250cdcfff48caa78

            }

            return expResult;
        }


        /// <summary>
        /// http请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string httpSendMethod(string url)
        {
            string result = string.Empty;



            return result;
        }

        /// <summary>
        /// http漏洞代码实现  
        /// down 表示网站无法访问
        /// error 表示没有漏洞 返回error
        /// 成功则返回结果
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private  static string thinkphpRce(string url)
        {
            string result = string.Empty;

            ///调用httpSendMethod 实战漏洞逻辑
            ///
            string errorcase = "error";

            string res = httpSendMethod(url); //调用http请求请求结果


            if (res.Contains("有漏洞标志")) //
            {
                //通过正则表达式方式直接刷选出漏洞然后赋值结果

                string res1 = res.Split('|')[0]; //编程思维逻辑思维方式思考结果
                result = res1;  //最终结果

            }else
            {


                result = errorcase;
            }



            return result;
        }


    }
}
