using System;
using System.Threading;

namespace AlarmClock
{
    // 定义闹钟类
    public class AlarmClock
    {
        // 事件：嘀嗒
        public event EventHandler Tick;

        // 事件：响铃
        public event EventHandler Alarm;

        // 设置闹钟时间
        public TimeSpan AlarmTime { get; set; }

        // 启动闹钟
        public void Start()
        {
            while (true)
            {
                // 获取当前时间
                var currentTime = DateTime.Now.TimeOfDay;

                // 触发嘀嗒事件
                Tick?.Invoke(this, EventArgs.Empty);

                // 判断是否到达闹钟时间
                if (currentTime >= AlarmTime)
                {
                    // 触发响铃事件
                    Alarm?.Invoke(this, EventArgs.Empty);
                    break;
                }

                // 等待一秒钟
                Thread.Sleep(1000);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var alarmClock = new AlarmClock();
            alarmClock.AlarmTime = new TimeSpan(8, 0, 0); // 设置闹钟时间为早上8点

            // 订阅嘀嗒事件
            alarmClock.Tick += (sender, e) =>
            {
                Console.WriteLine("嘀嗒...");
            };

            // 订阅响铃事件
            alarmClock.Alarm += (sender, e) =>
            {
                Console.WriteLine("闹钟响了！该起床了！");
            };

            // 启动闹钟
            alarmClock.Start();
        }
    }
}
