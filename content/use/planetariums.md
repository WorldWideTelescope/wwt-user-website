+++
date = 2020-04-15
title = "Using WWT in Planetariums"
aliases = ["/Use/Planetariums"]

[extra]
titlebox_class = "background-19026"
+++

The free, open-source AAS WorldWide Telescope [Windows client][windows-client]
can power planetariums ranging from single-projector portable domes to
world-class facilities with dozens of projectors.

[windows-client]: @/download.md#windows-client


# Flexibility

In the simplest setup, WWT can run on a single computer running Windows with
one monitor for the control interface. In more complex installations, WWT can
drive a cluster of servers to create a multi-channel dome projection. In this
mode WWT synchronizes the display video and the data across servers, and
manages the status of the WWT server power for each server in the cluster.

<section class="flex-cards">

{% card(text="Go to the Planetarium Guide", url="https://docs.worldwidetelescope.org/planetarium-guide/1/", html=1) %}
For detailed documentation on how to set up WWT in single- and multi-channel
scenarios, visit the <b>WWT Planetarium Guide</b>.
{% end %}


{% card(text="Get the Remote Control", url="../download/#remote-control", html=1) %}
The <b>WWT Remote Control</b> utility helps you synchronize and manage WWT
installations on a cluster of display servers.
{% end %}

</section>

WWT handles warping and blending for the dome and comes with tools and
instructions to [solve for the needed calibration][multi-channel-setup].
Performance has been optimized for real-time display on modern graphics
hardware with [controls to ensure smooth playback][perf].

[multi-channel-setup]: https://docs.worldwidetelescope.org/planetarium-guide/1/multi-channel-setup/
[perf]: https://docs.worldwidetelescope.org/planetarium-guide/1/performance/


# Features

WWT comes with batteries included:

<section class="flex-cards">

{% card(text="Learn About Tours", url="https://docs.worldwidetelescope.org/user-manual/1/guidedtours/", html=1) %}
The same software that powers your dome also powers the <a
href="//worldwidetelescope.org/webclient/">WWT Web client</a> — opening up exciting possibilities for
people to experience your content both in your dome and in the comfort of
their own homes. WWT “tours” deliver a guided multimedia experience in both
contexts.
{% end %}

{% card(text="Custom Controller Docs", url="https://docs.worldwidetelescope.org/planetarium-guide/1/controllers/") %}
Use MIDI devices, XBox controllers, and more to allow presenters full control
over live presentations.
{% end %}

{% card(text="Cache Management Docs", url="https://docs.worldwidetelescope.org/planetarium-guide/1/caches/", html=1) %}
Manage data caching and synchronize caches between display servers to get the
best of both worlds: data streamed from the internet <i>and</i> reliable
performance.
{% end %}

</section>


# Trust

And did we mention that WWT is free and open-source? It’s sponsored by the
non-profit [American Astronomical Society][aas] (AAS), the major organization of
professional astronomers in North America.

[aas]: https://aas.org/

<section class="flex-cards">

{% card(text="Get the Source", url="https://github.com/WorldWideTelescope") %}
WWT software development is planned and conducted in the open on GitHub.
{% end %}

{% card(text="Learn about AAS", url="https://aas.org/about-aas") %}
As a non-profit scholarly society, AAS will always prioritize scientific
accuracy, open access, and inclusiveness.
{% end %}

</section>
