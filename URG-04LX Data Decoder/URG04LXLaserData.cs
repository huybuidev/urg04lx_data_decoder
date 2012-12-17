using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace URG_04LX_Data_Decoder
{
    class URG04LXLaserData
    {
        public const int LASER_DATA_LENGTH = 682;
        int[] _data;
        DateTime _date;

        // Default constructor
        public URG04LXLaserData()
        {
            // Create new array of int
            _data = new int[LASER_DATA_LENGTH];
            // Init current time
            _date = DateTime.Now;
        }

        // Constructor with initial data
        public URG04LXLaserData(int[] data, DateTime date)
        {
            _date = date;
            if (data.Length != LASER_DATA_LENGTH)
            {
                // Create new array of int
                _data = new int[LASER_DATA_LENGTH];
            }
            else
            {
                // Copy data for this instance
                _data = data;
            }
        }

        public int[] Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public DateTime LogDate
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public long LogTimestamp
        {
            get
            {
                return GetUnixTimestamp(_date);
            }
        }

        public static long GetUnixTimestamp(DateTime date)
        {
            // Find unix timestamp (seconds since 01/01/1970)
            long ticks = date.Ticks - DateTime.Parse("01/01/1970 00:00:00").Ticks;
            //Convert windows ticks to seconds
            return (ticks / 10000000);
        }

        // Export UrgBenri data file (*.ubh)
        public static void ExportUrgBenriDataFile(string strFileName, List<URG04LXLaserData> lstData)
        {
            FileStream fs = new FileStream(strFileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            // Write header values
            sw.WriteLine(@"[model]
URG-04LX(Hokuyo Automatic Co.,Ltd.)
[frontStep]
384
[minDistance]
20
[maxDistance]
5600
[motorSpeed]
600
[totalSteps]
1024
[captureMode]
GD_Capture_mode
[scanMsec]
100
[startStep]
44
[endStep]
725
[serialNumber]
H0901636");
            // Start writing data
            for (int i = 0; i < lstData.Count; i++)
            {
                sw.WriteLine("[timestamp]");
                sw.WriteLine(lstData[i].LogTimestamp.ToString());
                sw.WriteLine("[logtime]");
                sw.WriteLine(lstData[i].LogDate.ToString("yyyy:MM:dd:hh:mm:ss:ffff"));
                sw.WriteLine("[scan]");
                for (int j = 0; j < lstData[i].Data.Length; j++)
                {
                    if (j != 0) sw.Write(";");
                    sw.Write(lstData[i].Data[j].ToString());
                }
                sw.Write("\r\n");
            }

            sw.Close();
            fs.Close();
        }
    }
}
