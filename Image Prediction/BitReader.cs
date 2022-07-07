using System;
using System.IO;

namespace Image_Prediction
{
    class BitReader:IDisposable
	{
		private int ctBits;
		private byte readBuffer;
		private BinaryReader binaryReader;
		private FileStream myFile;

		public BitReader(string fileName)
		{
			myFile = new FileStream(fileName, FileMode.OpenOrCreate);
			binaryReader = new BinaryReader(myFile);
		}

		private bool IsBufferEmpty()
		{

			if (ctBits == 0)
			{
				return true;
			}

			else
			{
				return false;
			}

		}

		public byte ReadBit()
		{
			byte result = 0;

            if (IsBufferEmpty())
            {
				readBuffer = binaryReader.ReadByte();
				ctBits = 8;
            }

			result = (byte)(0x80 & readBuffer);
			result = (byte)(result >> 7);
			readBuffer = (byte)(readBuffer << 1);

			ctBits--;

			return result;
		}

		public int ReadNBits(int nrOfBits)
		{
			int result = 0;

			for (int i = 0; i < nrOfBits; i++)
			{
				result = (int) (result << 1);
				result = (int) (result | ReadBit());
			}

			return result;

		}

		public void Dispose()
		{
			binaryReader.Dispose();
		}

	}
}
