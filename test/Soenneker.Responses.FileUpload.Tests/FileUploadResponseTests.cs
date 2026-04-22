using Soenneker.Tests.HostedUnit;

namespace Soenneker.Responses.FileUpload.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class FileUploadResponseTests : HostedUnitTest
{
    public FileUploadResponseTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
