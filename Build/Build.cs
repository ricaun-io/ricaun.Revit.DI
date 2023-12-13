using Nuke.Common;
using Nuke.Common.Execution;
using ricaun.Nuke;
using ricaun.Nuke.Components;

class Build : NukeBuild, IPublishPack, IRevitPackageBuilder, IPrePack
{
    string IHazPackageBuilderProject.Name => "Example";
    string IHazRevitPackageBuilder.Application => "Revit.App";
    public static int Main() => Execute<Build>(x => x.From<IPublishPack>().Build);
}