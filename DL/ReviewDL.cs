using BA.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BA.DL
{
    public class ReviewDL
    {
        public static bool storeReviewDataInFile(Review review, string path)
        {
            if(review != null)
            {
                string line = review.getName() + "," + review.getReview() + Environment.NewLine;
                File.AppendAllText(path, line);
                return true;
            }
            return false;
        }

        public static List<Review> viewReview(string path)
        {
            if (File.Exists(path))
            {
                List<Review> reviewList = new List<Review>();
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    var values = record.Split(',');
                    Review review = new Review(values[0], values[1]);
                    reviewList.Add(review);
                }
                fileVariable.Close();
                return reviewList;
            }
            return null;
        }
    }
}
