+++
date = 2020-04-15
title = "WWT Downloads"
aliases = ["/Download"]

[extra]
titlebox_class = "background-19036"
+++

<section class="flex-cards">

{% card(text="Launch the web client", url="/webclient/", html=1) %}
You don’t need to download anything to start using AAS WorldWide Telescope
— our <b>web client</b> runs right in your browser.
{% end %}

{% card(text="Install pywwt", url="https://pywwt.readthedocs.io/en/stable/installation.html", html=1) %}
If you want to use WWT from Python, find installation instructions for
<b>pywwt</b> on that project’s documentation pages.
{% end %}

</section>


# AAS WorldWide Telescope for Windows: Version 6 {#windows-client}

The current stable release of WWT for Windows is the Version 6 series. The most
recent release is version 6.1.0.0 (2022 Feb 15; [technical changelog][w6cl]).

[w6cl]: https://github.com/WorldWideTelescope/wwt-windows-client/blob/release/WWTExplorer3d/CHANGELOG.md

{{ bigbutton(text="Download WWT 6.1.0.0", url="https://web.wwtassets.org/releases/wwt/wwtsetup-6.1.0.0.msi") }}

See [the WWT 2022 release notes][w6rn] for a big-picture overview of what’s
changed since version 5. If you have a “production” installation of WWT, such as
a planetarium or museum kiosk, that is based on the Version 5 series, **test
carefully before upgrading**. There are some internal changes that may require
updates to existing setups. 

[w6rn]: https://worldwidetelescope.github.io/editions/2022/winclient/

### Recommended System Requirements

- Any recent CPU
- 8+ GB system memory
- Discrete GPU with 1+ GB VRAM and DirectX 11 compatibility

WWT 6 runs on Windows 7/8/8.1/10/11, in either 32- or 64-bit mode, depending on
your operating system. It also supports native DirectX 11, DirectX 10, and has
some support for down-level DirectX 9 hardware running through the DirectX 11
API. There is a known incompatibility with Intel Iris Xe integrated graphics;
see [the release notes][w6rn] for more information.

Do not attempt to install recent versions of WWT on operating systems older than
Windows 7. It will not run and can potentially prevent the legacy version from
running.


# WWT for Windows: Old Version 5 Series

The previous stable version of AAS WorldWide Telescope is the Version 5 series.
The last release was version 5.5.3 (July, 2016).

- [Download WWT 5.5.3](https://web.wwtassets.org/releases/wwt/wwtsetup-5.5.3.msi")

WWT 5.5 runs on Windows 7/8/8.1/10, in either 32- or 64-bit mode, depending on
your operating system. It also supports native DirectX 11, DirectX 10, and has
some support for down-level DirectX 9 hardware running through the DirectX 11
API. Do not attempt to install WWT 5.0 or higher on Windows XP. It will not run
and can potentially prevent the legacy version from running.


# WWT Remote Control (Windows only) {#remote-control}

The WWT Remote Control is a Windows utility that assists with remotely
operating the main WWT application, especially in cluster environments as
found in planetariums.

- [Download WWTRemote 5.0.0](http://web.wwtassets.org/releases/remote/wwtremote-5.0.0.msi)
- [Download WWTRemote 2.1.1 Legacy](http://web.wwtassets.org/releases/remote/wwtremote-2.1.1.msi)

The Remote Control is not being maintained and may not work correctly with the
version 6 series of the Windows application. See [the WWT 2022 release notes][rcrn] for
more information.

[rcrn]: https://worldwidetelescope.github.io/editions/2022/remote/


# WWT Add-in for Excel (Windows only) {#excel-addin}

The WWT Excel add-in enables Windows users to efficiently highlight, organize,
and import their data into the AAS WorldWide Telescope visualization
environment using the familiar capabilities of Microsoft Excel.

- [Download the WWT Excel Add-in 1.0](http://web.wwtassets.org/releases/exceladdin/wwtexceladdin-1.0.msi).

The Excel add-in is not being maintained and is unlikely to work on recent OS
installations. See [the WWT 2022 release notes][earn] for more information.

[earn]: https://worldwidetelescope.github.io/editions/2022/excel-addin/


# WorldWide Telescope Legacy (3.1) for Windows XP and Vista

The WorldWide Telescope legacy version (WWT 3.1; May 2015) supports Windows XP, Windows
Vista, and DirectX 9.0c hardware running as a 32-bit application. Do not
attempt to install WWT 5.0+ on Windows XP: it will not run and can potentially
prevent the legacy version from running.
[Download WWT Legacy 3.1.52](https://web.wwtassets.org/releases/wwt/wwtsetup-3.1.52.msi).

To run this software, you’ll need the following:

- Windows XP or Vista
- Discrete graphics card w/ 512MB VRAM, High End GTX480 class or better w/ 1GB VRAM recommended
- [Microsoft .NET Framework 4.0](https://www.microsoft.com/en-us/download/details.aspx?id=17718)


# Legacy WWT SDK

Released in 2015, the WWT Software Development Kit (SDK) and Academic
Development Kit (ADK) provided a framework for the development of
WWT-compatible software on the Windows/.NET platform. It is not recommended
for use anymore — consult
[the WWT documentation hub](https://docs.worldwidetelescope.org/) to learn
about the modern ecosystem for WWT data processing and software development.

- [Download the 2015 SDK/ADK](https://wwtweb.blob.core.windows.net/drops/WWTSDK.msi)
