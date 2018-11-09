﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHTML { get; set; }
        public Artist[] Artist { get; set; }
        public bool Favorite { get; set; }

        public string DisplatText
        {
            get
            {
                return SeriesTitle + "#" + IssueNumber;
            }
        }
        //series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "_").ToLower() + "_" + IssueNumber + ".jpg";
            }
        }
    }
}