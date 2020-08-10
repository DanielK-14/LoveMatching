using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FaceBook_Application_WForms
{
    internal static class DataAnalyst
    {
        public static List<string> AnalyzeData(object obj)
        {
            List<string> analayzedData = new List<string>();
            out string pictureUrl;
            out string infoString;
            if (obj is Post)
            {
                analyzePost(obj as Post, out infoString, out pictureUrl);
            }
            else if (obj is User)
            {
                analyzeFriend(obj as User, out infoString, out pictureUrl);
            }
            else
            {
                analyzeEvent(obj as Event, out infoString, out pictureUrl);
            }

            return analayzedData;
        }

        private static void analyzeEvent(Event i_Event, out string o_Data, out string o_PicUrl)
        {
            StringBuilder eventInfo = new StringBuilder();
            eventInfo.AppendLine(string.Format("Event {0}{1} Starts in: {2}{1} Ends in: {3}",
                i_Event.Name, Environment.NewLine, i_Event.StartTime.ToString(), i_Event.EndTime.ToString()));
            eventInfo.AppendLine(string.Format("Description:{0}{1}", Environment.NewLine, i_Event.Description));

            o_Data = eventInfo.ToString();
            o_PicUrl = i_Event.PictureLargeURL;
        }

        private static void analyzeFriend(User i_Friend, out string o_Data, out string o_PicUrl)
        {
            StringBuilder friendInfo = new StringBuilder();
            friendInfo.AppendLine(string.Format("Your friend {0} has some intresting facts:", i_Friend.FirstName));
            friendInfo.AppendLine(string.Format("{0} Is {1}", i_Friend.FirstName, i_Friend.Gender.ToString()));
            friendInfo.AppendLine(string.Format("{0} Is {1}", i_Friend.FirstName, i_Friend.RelationshipStatus.ToString()));
            friendInfo.AppendLine(string.Format("Has {0} wallposts.", i_Friend.WallPosts.Count.ToString()));
            friendInfo.AppendLine(string.Format("Has {0} Subscribers.", i_Friend.Subscribers.Count.ToString()));

            o_Data = friendInfo.ToString();
            o_PicUrl = i_Friend.PictureLargeURL;
        }

        private static void analyzePost(Post i_Post, out string o_Data, out string o_PicUrl)
        {
            StringBuilder postInfo = new StringBuilder();
            postInfo.AppendLine(string.Format("Post: {0}.{1} Has {2} comments.{1} Was posted on {3}.",
                i_Post.Message, Environment.NewLine, i_Post.Comments.Count, i_Post.CreatedTime));

            o_Data = postInfo.ToString();
            o_PicUrl = i_Post.PictureURL;
        }
    }
}
