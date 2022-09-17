using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Smartphone : Phone
    {
        private static Regex symbolsRange = new Regex("^[]*$");

        protected int numberOfCameras;
        public Smartphone(string phoneNumber, int width, int height, Color color,
            int colorNumber, string secondPhoneNumber, int numberOfCameras)
            : base(phoneNumber, width, height, color, colorNumber, secondPhoneNumber)
        {
            this.numberOfCameras = numberOfCameras;
        }
        /// <summary>
        /// Method that takes photo and returns media as a string
        /// </summary>
        /// <param name="cameraID">Which camera to use starting from 1(front camera). Cannot be higher then numberOfCameras</param>
        /// <returns></returns>
        public virtual string Photo(int cameraID)
        {
            if (cameraID > numberOfCameras || cameraID <= 0)
            {
                Console.WriteLine("Invalid camera!");
                return "ERROR";
            }
            Console.WriteLine("Taking a photo...");
            return "photo";
        }

        /// <summary>
        /// Method that creates video and returns media as a string
        /// </summary>
        /// <param name="cameraID">Which camera to use starting from 1(front camera). Cannot be higher then numberOfCameras</param>
        /// <returns></returns>
        public virtual string Video(int cameraID)
        {
            if (cameraID > numberOfCameras || cameraID <= 0)
            {
                Console.WriteLine("Invalid camera!");
                return "ERROR";
            }
            Console.WriteLine("Shooting a video...");
            return "video";
        }
    }
}
