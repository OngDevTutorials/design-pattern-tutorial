using System;
using ObserverPattern.Old.Notifier;

namespace ObserverPattern.Old
{
    public class VideoData
    {
        #region Private Properties
        private string _title;
        private string _description;
        private string _fileName;
        private readonly EmailNotifier _emailNotifier;
        private readonly PhoneNotifier _phoneNotifier;
        private readonly YoutubeNotifier _youtubeNotifier;
        #endregion

        #region GetSetProperties
        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string value)
        {
            _title = value;
            VideoDataChanged();
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string value)
        {
            _description = value;
            VideoDataChanged();
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void SetFileName(string value)
        {
            _fileName = value;
            VideoDataChanged();
        }
        #endregion

        public VideoData()
        {
            _emailNotifier = new EmailNotifier();
            _phoneNotifier = new PhoneNotifier();
            _youtubeNotifier = new YoutubeNotifier();
        }

        private void VideoDataChanged()
        {
            var title = GetTitle();
            var description = GetDescription();
            var fileName = GetFileName();

            _emailNotifier.Notify(title, description, fileName);
            _phoneNotifier.Notify(title, description, fileName);
            _youtubeNotifier.Notify(title, description, fileName);
        }
    }
}
