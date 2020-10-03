using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryPro.Models
{
    /// <summary>
    /// 选号器类
    /// </summary>
    class Selector
    {
        //红色球池
        public List<string> RedNumberList { get; set; }
        //蓝色球池
        public List<string> BlueNumberList { get; set; }

        public List<DoubleChromosphere> SelectNumberList { get; set; } = new List<DoubleChromosphere>();

        private Random random = new Random();

        /// <summary>
        /// 通过构造方法初始化红蓝球池中的数字
        /// </summary>
        public Selector()
        {
            RedNumberList = new List<string>
            {
                "01","02","03","04","05","06","07","08","09","10",
                "11","12","13","14","15","16","17","18","19","20",
                "21","22","23","24","25","26","27","28","29","30",
                "31","32","33"
            };
            BlueNumberList = new List<string>
            {
                "01","02","03","04","05","06","07","08","09","10",
                "11","12","13","14","15","16"
            };
        }
        /// <summary>
        /// 随机方法生成随机红蓝数字组合
        /// </summary>
        /// <returns></returns>
        public List<string> GetRandomList()
        {
            List<string> numberList=new List<string>();
            while (true)
            {
                if (numberList.Count==6)
                {
                    break;
                }
                string num = RedNumberList[random.Next(33)];
                if (numberList.Contains(num))
                {
                    continue;
                }
                else
                {
                    numberList.Add(num);
                }
            }
            numberList.Add(BlueNumberList[random.Next(16)]);
            return numberList;
        }
    }
}
