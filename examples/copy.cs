using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Qiniu.RS;
using Qiniu.RPC;

namespace ConsoleDemo
{
    class BucketManager
    {

        public static void Copy(string bucketSrc, string keySrc, string bucketDest, string keyDest)
        {
            //实例化一个RSClient对象，用于操作BucketManager里面的方法
            RSClient client = new RSClient();
            CallRet ret = client.Copy(new EntryPathPair(bucketSrc, keySrc, bucketDest, keyDest));
            if (ret.OK)
            {
                Console.WriteLine("Copy OK");
            }
            else
            {
                Console.WriteLine("Failed to Copy");
            }
        }

        static void Main(string[] args)
        {
            //初始化AK，SK
            Qiniu.Conf.Config.ACCESS_KEY = "Access_Key";
            Qiniu.Conf.Config.SECRET_KEY = "Secret_Key";
            //要测试的空间和key，并且这个key在你空间中存在
            String bucket = "Bucket_Name";
            String key = "Bucket_key";

            //将文件从文件key复制到文件key2, 可以在不同bucket移动
            String key2 = "yourjavakey";
            //调用Move方法
            BucketManager.Stat(bucket,key,bucket,key2);

        }
    }
}