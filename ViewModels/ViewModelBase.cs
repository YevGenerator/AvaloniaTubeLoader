using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using SharpTube;
using VideoLibrary;

namespace AvaloniaTubeLoader.ViewModels;

public partial class ViewModelBase : ObservableObject, IVideoContainer<ObservableCollection<YouTubeVideo>>
{
    [ObservableProperty]
    private string _videoName = "";

    public YouTubeVideo? MuxedVideo { get; set; }
    public ObservableCollection<YouTubeVideo> Videos { get; set; } = [];
    public ObservableCollection<YouTubeVideo> Audios { get; set; } = [];

    public void Test()
    {
        var runner = new YoutubeRunner();
        YoutubeRunner.DistributeVideos(runner.GetVideos(""), this );
    }
    
}