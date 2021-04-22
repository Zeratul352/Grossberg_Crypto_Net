using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Grossberg_crypto_system
{
    class GrossbergNet
    {
        private static int dimension = 8;
        private static int multiplier = 32;
        private bool randomflag = false;
        Random random = new Random();

        Matrix<double> Core;
        Dictionary<char, Vector<double>> map;
        public GrossbergNet()
        {
            Core = CreateMatrix.Dense<double>(dimension * multiplier, dimension * multiplier);
            map = new Dictionary<char, Vector<double>>();
        }

        public void Train(string source, string result)
        {
            if (source.Length != result.Length)
                throw new Exception("Train vectors have different dimensions");

            for(int i = 0; i < source.Length; i++)
            {
                var x = ToBytes(Convert.ToChar(source[i]));
                var y = ToBytes(Convert.ToChar(result[i]));
                //var y = ToRandomBytes();
                var W = x.ToColumnMatrix() * y.ToRowMatrix();
                Core += W;
            }
        }


        public string Encode(string source)
        {
            string result = "";
            for(int i = 0; i < source.Length; i++)
            {
                char a = Convert.ToChar(source[i]);
                var x = map[a];//ToBytes(Convert.ToChar(source[i]));
                var y = x * Core;
                var achar = ToChar(NeuronFunc(y));
                //var achar = ToInt(NeuronFunc(y));
                result += achar;
            }

            return result;
        }

        public string Decode(string result)
        {
            string source = "";
            for (int i = 0; i < result.Length; i++)
            {
                char a = Convert.ToChar(result[i]);
                var y = map[a];//ToBytes(Convert.ToChar(result[i]));
                var x = y * Core.Transpose();
                
                var achar = ToChar(NeuronFunc(x));
                source += achar;
            }
            /*var nums = result.Split(' ');
            foreach(var num in nums)
            {
                var y = ToRandomBytes(Convert.ToInt32(num));
                var x = y * Core.Transpose();

                var achar = ToChar(NeuronFunc(x));
                source += achar;
            }*/

            return source;
        }

        private Vector<double> NeuronFunc(Vector<double> data)
        {
            Vector<double> result = CreateVector.Dense<double>(multiplier * dimension);
            for(int i = 0; i < dimension * multiplier; i++)
            {
                if (data[i] > 0)
                    result[i] = 1;
                else
                    result[i] = -1;
            }
            return result;
        }
        Vector<double> ToRandomBytes(int rand)
        {
            Vector<double> vector = CreateVector.Dense<double>(dimension * multiplier);
            //int rand = random.Next(0, 1073741824);
            string bytes = Convert.ToString(rand, 2);
            int starter = dimension * multiplier - bytes.Length;
            for (int i = 0; i < starter; i++)
            {
                vector[i] = -1;
            }
            for (int i = starter; i < dimension * multiplier; i++)
            {
                if (Convert.ToInt32(bytes[i - starter]) == 49)
                    vector[i] = 1;
                else if (Convert.ToInt32(bytes[i - starter]) == 48)
                    vector[i] = -1;
                else
                    throw new Exception("Some error in converting to bytes occured");
            }
            return vector;
        }
        Vector<double> ToRandomBytes()
        {
            Vector<double> vector = CreateVector.Dense<double>(dimension * multiplier);
            int rand = random.Next(0, 1073741824);
            string bytes = Convert.ToString(rand, 2);
            int starter = dimension * multiplier - bytes.Length;
            for (int i = 0; i < starter; i++)
            {
                vector[i] = -1;
            }
            for (int i = starter; i < dimension * multiplier; i++)
            {
                if (Convert.ToInt32(bytes[i - starter]) == 49)
                    vector[i] = 1;
                else if (Convert.ToInt32(bytes[i - starter]) == 48)
                    vector[i] = -1;
                else
                    throw new Exception("Some error in converting to bytes occured");
            }
            return vector;
        }
        Vector<double> ToBytes(char a)
        {
            string bytes = Convert.ToString(a, 2);
            Vector<double> vector = CreateVector.Dense<double>(dimension * multiplier);
            


            int start = dimension - bytes.Length;
            for(int i = 0; i < start; i++)
            {
                vector[i] = -1;
            }
            for(int i = start; i < dimension; i++)
            {
                if (Convert.ToInt32(bytes[i-start]) == 49)
                    vector[i] = 1;
                else if (Convert.ToInt32(bytes[i-start]) == 48)
                    vector[i] = -1;
                else
                    throw new Exception("Some error in converting to bytes occured");
            }
            for(int i = dimension; i < dimension * multiplier; i++)
            {
                int r = random.Next(100);
                if (r > 50)
                    vector[i] = 1;
                else
                    vector[i] = -1;
            }
            map.Add(a, vector);
            return vector;

        }

        char ToChar(Vector<double> bytes)
        {
            for(int i = 0; i < dimension * multiplier; i++)
            {
                if (bytes[i] == -1.0)
                    bytes[i] = 0;
            }
            string line = "";
            for(int i = 0; i < dimension; i++)
            {
                line +=Convert.ToInt32(bytes[i]).ToString();
            }
            return Convert.ToChar(Convert.ToInt32(line, 2));
        }

        int ToInt(Vector<double> bytes)
        {
            for (int i = 0; i < dimension * multiplier; i++)
            {
                if (bytes[i] == -1.0)
                    bytes[i] = 0;
            }
            string line = "";
            for (int i = 0; i < dimension * multiplier; i++)
            {
                line += Convert.ToInt32(bytes[i]).ToString();
            }
            return Convert.ToInt32(line, 2);
        }

    }
}
