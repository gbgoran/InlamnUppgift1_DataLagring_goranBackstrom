using System;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace InlamnUppgift1_DataLagring_goranBackstrom
{
    internal class FileOpenPicker
    {
        public PickerLocationId SuggestedStartLocation { get; internal set; }
        public object FileTypeFilter { get; internal set; }
        public PickerViewMode ViewMode { get; internal set; }

        internal System.Threading.Tasks.Task<StorageFile> PickSingleFileAsync()
        {
            throw new NotImplementedException();
        }
    }
}