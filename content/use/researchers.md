+++
date = 2020-04-15
title = "Using WWT for Research"
aliases = ["/Use/Researchers"]

[extra]
titlebox_class = "background-19032"
+++

The **pywwt** package exploits the power of AAS WorldWide Telescope’s
rendering engine to interactively visualize astronomical images and data
tables inside your Jupyter notebooks. You can try it out right now with our
cloud-based notebooks:

{{ bigbutton(text="Get started with pywwt", url="https://pywwt.readthedocs.io/en/stable/#quick-start") }}

Here’s a video of pywwt in action:

{{ youtube(id="cL9Hd7cKnNU", class="youtube-embed") }}

There’s a lot more where that came from in [the pywwt playlist on the WWT YouTube channel][youtube-pywwt].

[youtube-pywwt]: https://www.youtube.com/playlist?list=PLozhKWk-h8YDYSRHzeLmznlQZHM29F18i


# Get Your Data into WWT

For basic image and tabular visualization, pywwt is all you need. But WWT can
visualize many kinds of data sets, ranging from 3D models to terabyte-scale
all-sky surveys.

<section class="flex-cards">

{% card(text="Read the Data Guide", url="https://docs.worldwidetelescope.org/data-guide/1/", html=1) %}
The <b>WWT Data Guide</b> is your one-stop-shop to understand the details of
the different data formats used in AAS WorldWide Telescope and the software
tools that create and manipulate them.
{% end %}

{% card(text="toasty documentation", url="https://toasty.readthedocs.io/", html=1) %}
Use the <b>toasty</b> Python package to “tile” large images for efficient
Web-based visualization.
{% end %}

{% card(text="wwt_data_formats docs", url="https://wwt-data-formats.readthedocs.io/", html=1) %}
The <b>wwt_data_formats</b> Python package documents the details of WWT’s
low-level data formats, and provides tools for reading and writing them.
{% end %}

</section>


# Share Your Science on the Web

One of WWT’s unique strengths is that it’s built for the Web, so that you can
share WWT visualizations with just about anyone anywhere. You can use it to
build interactives ranging from simple embeds in your personal webpage up to
full-blown custom web applications.

<section class="flex-cards">

{% card(text="Go to the Tour Authoring Guide", url="https://docs.worldwidetelescope.org/tour-authoring-guide/1/", html=1) %}
<b>Tours</b> are scripted, multimedia experiences that guide the viewer
through WWT’s simulated universe. Not only does WWT make it easy to create
tours that explain your research, it makes it easy to share them as well!
{% end %}

{% card(text="WebGL Engine docs", url="https://worldwidetelescope.gitbook.io/webgl-engine-reference/", html=1) %}
The WWT web client and pywwt are powered by the <b>WWT WebGL Engine</b>, a
reusable JavaScript library. With a little web development elbow grease you
can build your own custom Web interactives.
{% end %}

{% card(text="Beta Inquiry", url="mailto:wwt@aas.org", html=1) %}
We are currently beta-testing support for easily creating WWT <a
href="https://journals.aas.org/landing/interactive-figures-201909/"><b>interactive
figures</b></a> in publications. If that sounds interesting to you, get in
touch to learn more!
{% end %}

</section>
