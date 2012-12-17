using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace URG_04LX_Data_Decoder
{
    class SCIP20MsgDecoder
    {
        private int[] _laser_data;
        private byte[] _raw_data;
        private string _strHexData;

        public SCIP20MsgDecoder()
        {
        }

        public SCIP20MsgDecoder(string strHexMsg)
        {
            DecodeMD(strHexMsg);
        }

        // String for laser data
        public string LaserDataText
        {
            get
            {
                string res = "";
                for (int i = 0; i < _laser_data.Length; i++)
                {
                    res += _laser_data[i].ToString() + "\r\n";
                }
                return res;
            }
        }

        // Laser data
        public int[] LaserData
        {
            get
            {
                return _laser_data;
            }
        }

        // Raw Data values
        public byte[] RawData
        {
            get
            {
                return _raw_data;
            }
        }

        // String of data values in hexadecimal
        public string HexData
        {
            get
            {
                return _strHexData;
            }
        }

        // Decode MD message in SCIP2.0
        public void DecodeMD(string strHexMsg)
        {
            string res = "";    // Store result
            string tmp;         // Temporary variable

            // Separate the command and return message
            string[] split_packet = { "0A 0A" };
            string[] packet = strHexMsg.Split(split_packet, StringSplitOptions.RemoveEmptyEntries);

            // Split packets in return message
            string[] split_data = { "0A" };
            string[] data = packet[1].Split(split_data, StringSplitOptions.RemoveEmptyEntries);

            // Data start from the 3rd packet
            for (int i = 3; i < data.Length; i++)
            {
                tmp = ChecksumNGet(data[i]);
                if (tmp != "")
                {
                    res += " " + tmp;
                }
                else
                {
                    // Error in checksum
                    _strHexData = "";
                }
            }
            // Return the result after removing outside spaces
            _strHexData = res.Trim();

            // Update the raw data byte array
            _raw_data = HexString2ByteArray(_strHexData);

            // Update the laser data
            _laser_data = Decode3Char(_raw_data);
        }

        // Checksum a packet and get the data only
        public static string ChecksumNGet(string strHexPacket)
        {
            strHexPacket = strHexPacket.Trim();
            byte[] res = HexString2ByteArray(strHexPacket);

            // Check sum for the data
            UInt32 sum = 0;
            for (int i = 0; i < res.Length - 1; i++)
            {
                sum += res[i];
            }
            // The last 6 bit and add 0x30
            sum = sum & Convert.ToUInt32("111111", 2);
            sum += 0x30;
            if (sum != res[res.Length - 1])
            {
                // Wrong checksum
                return "";
            }
            return strHexPacket.Remove(strHexPacket.Length - 3);
        }

        // Convert a hex string to a byte array
        public static byte[] HexString2ByteArray(string strHex)
        {
            string[] split_data = { " " };
            string[] data = strHex.Trim().Split(split_data, StringSplitOptions.RemoveEmptyEntries);
            byte[] res = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                res[i] = Convert.ToByte(data[i], 16);
            }
            return res;
        }

        // Convert a byte array to a hex string
        public static string ByteArray2HexString(byte[] data)
        {
            string res = "";
            for (int i = 0; i < data.Length; i++)
            {
                res += data[i].ToString("X2") + " ";
            }
            return res.Trim();
        }

        // Decode 3 character encoding data
        public static int[] Decode3Char(byte[] data)
        {
            // Return null if the data length is not valid
            if (data.Length % 3 != 0) return null;
            int[] res = new int[data.Length / 3];
            int value;
            for (int i = 0; i < data.Length; i += 3)
            {
                value = (data[i] - 0x30) * 4096;    // Shift left 12 bit
                value += (data[i + 1] - 0x30) * 64;   // Shift left 6 bit
                value += (data[i + 2] - 0x30);        // No bit shift
                res[i / 3] = value;
            }
            return res;
        }

    }
}
