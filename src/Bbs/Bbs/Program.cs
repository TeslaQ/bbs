using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bbs
{
    class Program
    {
        private static string USAGE = @"
パラメータが必須です。
以下のパラメータを指定してください。

listtopic       スレッド一覧を表示する
newtopic        新しいスレッドを作成する
post <topicid>  指定されたスレッドに投稿する
topic <topicid> 指定されたスレッドを表示する
";
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                // 引数が無い場合
                Console.WriteLine(USAGE);
                return;
            }

            switch (args[0])
            {
                case "listtopic":
                    // スレッド一覧

                    break;
                case "newtopic":
                    // 新規スレッドに投稿

                    break;
                case "post":
                    // 新規投稿

                    break;
                case "topic":
                    // 指定されたスレッドを表示する

                    break;
                default:
                    // エラー
                    Console.WriteLine(USAGE);
                    break;
            }

        }
    }
}
