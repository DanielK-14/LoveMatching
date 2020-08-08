using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper
using FacebookWrapper.ObjectModel;

namespace FaceBook_Application_WForms
{
    class test
    {
        static void Klum()
        {
            LoginResult result = FacebookWrapper.FacebookService.Login("1206785753020262",
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");

            User user = result.LoggedInUser;
        }
    }
}
