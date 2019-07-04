using ObserverPattern.New.Base;

namespace ObserverPattern.New
{
    public class VideoData : Subject
    {
        #region Private Properties
        private string _title;
        private string _description;
        private string _fileName;
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

        private void VideoDataChanged()
        {
            NotifyObservers(null);
        }
    }
}
