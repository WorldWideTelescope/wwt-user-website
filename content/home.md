+++
title = "AAS WorldWide Telescope"
template = "homepage.html"
aliases = ["/Home"]
+++

The WWT ecosystem includes a [Windows application][windows-client], a
[reusable JavaScript library][webgl], an [interactive web app][web-client],
[a Python toolkit][pywwt],
[backing data distribution services][data-services], [support tools][infra],
[documentation][docs], and [community].

[windows-client]: @/download.md#windows-client
[webgl]: https://worldwidetelescope.gitbook.io/webgl-engine-reference/
[web-client]: /webclient/
[pywwt]: https://pywwt.readthedocs.io/
[data-services]: https://wwt-api-client.readthedocs.io/en/latest/
[docs]: https://docs.worldwidetelescope.org/
[infra]: https://docs.worldwidetelescope.org/#exploring-wwt-infrastructure
[community]: https://wwt-forum.org/

WWT is a **free and open-source** project brought to you by the non-profit
[American Astronomical Society][aas] (AAS), the major organization of
professional astronomers in North America. WWT’s web services are sponsored by
the [.NET Foundation][dnf].

[aas]: https://aas.org/
[dnf]: https://dotnetfoundation.org/

<section class="flex-cards">

{% card(text="WWT and Research", url="../use/researchers", html=1) %}
WWT’s sophisticated Web-based visualization capabilities allow
<b>researchers</b> to explore and share their data.
{% end %}

{% card(text="WWT and Education", url="../use/educators", html=1) %}
Visualizing the universe in accurate 3D detail isn’t just cool — it’s
effective <b>education</b>.
{% end %}

{% card(text="WWT and Planetariums", url="../use/planetariums", html=1) %}
From single-projector portable setups to high-end multi-channel systems, WWT
can power your <b>planetarium</b>.
{% end %}

</section>

{% videoteaser(lbid="intro", img="../assets/video-thumbnail.jpg", ytid="CD_W6wJp26E") %}
<i>Watch our trailer for a video introduction to WWT. Even better, go ahead,
<a href="/webclient/">open the WWT Web client</a>, and start exploring!</i>
{% end %}


# Get Started with WWT

Because WWT lives on the Web, you can get started right away:

- If you’re interested in visualizing data in Python, check out our
  cloud-based [sample pywwt notebooks][pywwt-notebooks].
- If that’s not for you, [launch the WWT web client](/webclient/).

[pywwt-notebooks]: https://pywwt.readthedocs.io/en/stable/#quick-start


# Unique Features

AAS WorldWide Telescope marries powerful technology and user-friendliness.

<section class="flex-cards">

{% card(text="Tour Authoring Guide", url="https://docs.worldwidetelescope.org/tour-authoring-guide/1/", html=1) %}
<b>Tours</b> are scripted, multimedia experiences that guide the viewer
through WWT’s simulated universe. Create and share tours to teach astronomical
concepts, showcase your data, or share your passion for the cosmos!
{% end %}

{% card(text="WebGL Engine docs", url="https://worldwidetelescope.gitbook.io/webgl-engine-reference/", html=1) %}
WWT is <b>built for the web</b> so that you can share your content anywhere
that web browsers run — which is everywhere! You can embed WWT in a webpage
in a few minutes, or build your own <a
href="http://cxc.harvard.edu/csc2/wwt.html">sophisticated custom
application</a>.
{% end %}

{% card(text="Data Guide", url="https://docs.worldwidetelescope.org/data-guide/1/", html=1) %}
<a href="https://github.com/WorldWideTelescope/"><b>Open source</b></a> and
<b>open data</b> are at the core of WWT’s design. No need to ask for
permission — you can remix your own images, 3D models, tours, maps, and more
into the WWT environment.
{% end %}

</section>


# A Team Effort

WWT is a [.NET Foundation][dnf] project brought to you by the
[American Astronomical Society][aas] (AAS). Work on WWT has been supported by
those organizations, the [National Science Foundation][nsf], the
[Gordon and Betty Moore Foundation][moore], and [Microsoft].

[sandt]: https://skyandtelescope.org/
[nsf]: https://www.nsf.gov/
[moore]: https://www.moore.org/
[Microsoft]: https://www.microsoft.com/

If you’d like to get involved, read our page on how to [connect](@/connect.md)
with the WWT community, [sign up] for the WWT newsletter, or follow us on
[Twitter], [YouTube], or [Facebook].

[sign up]: https://bit.ly/wwt-signup
[Twitter]: https://twitter.com/wwtelescope
[YouTube]: https://www.youtube.com/c/AASWorldWideTelescope
[Facebook]: https://facebook.com/wwtelescope
