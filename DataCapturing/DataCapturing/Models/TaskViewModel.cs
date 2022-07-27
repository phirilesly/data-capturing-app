using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataCapturing.Models
{
    public class TaskViewModel

    {
        public string TimeLeft { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double ProgressValue { get; set; }
        public string Progress { get; set; }
        public string Status { get; set; }
    }
    public class TrackActivityViewModel
    {
        public string Time { get; set; }
        public string Comment { get; set; }
        public ImageSource Img { get; set; }
    }
    public class TrackActivityModel
    {
        public List<TaskViewModel> GetTask()
        {
            List<TaskViewModel> list = new List<TaskViewModel>();
            list.Add(new TaskViewModel { Description = "dummy data is benign information that does not contain any useful data, but serves to reserve space where real data is nominally present. Dummy data can be used as a placeholder for both testing and operational purposes.", Name = "Recieve Donation in Chivi", ProgressValue = 0.5, Progress = "50%", Status = "In Progress", TimeLeft = "2 Days left" });
          
            return list;
        }
    
            public List<TrackActivityViewModel> Get()
            {
                List<TrackActivityViewModel> list = new List<TrackActivityViewModel>();
                list.Add(new TrackActivityViewModel { Time = "0777777777", Comment = "Tom John", Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmNdSL0wetARyMZVIRgtl2yPZyzXSJQx4EzA" });
                list.Add(new TrackActivityViewModel { Time = "08999383838", Comment = "Mr Moyo", Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRij6dtiHizH96qpCOe8WeXXP3yLyQJkPdGVg" });
                list.Add(new TrackActivityViewModel { Time = "077373939393", Comment = "Ruva", Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmNdSL0wetARyMZVIRgtl2yPZyzXSJQx4EzA" });
                return list;
            }
        
    }
}
