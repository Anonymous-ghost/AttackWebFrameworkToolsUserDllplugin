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
            string downcase = "down";
            string errorcase = "error";

            string thinkphpRceRes = thinkphpRce(url);



            if (downcase.Equals(thinkphpRceRes))
            {

                return downcase;
            }else if (errorcase.Equals(thinkphpRceRes))
            {

                expResult = errorcase;
            }else
            {

                expResult = thinkphpRceRes; //系统系统写结果

                expResult = thinkphpRceRes+ "|5a75574b96ce583b250cdcfff48caa78|"; //用户自己写成功结果系统不管
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
            string downcase = "down";
            string errorcase = "error";

            ///调用httpSendMethod 实战漏洞逻辑
            ///

            string res = httpSendMethod(url);


            if (downcase.Equals(res))  //网站无法访问获取其他错误可以返回down
            {

                return downcase;

            }else if (errorcase.Equals(res)){  //没有漏洞返回error


                result = errorcase;
            }else
            {


                result = res;  //成果则返回成功结果
            }




            return result;
        }


    }
}
