[![Build Status](https://dev.azure.com/aasworldwidetelescope/WWT/_apis/build/status/WorldWideTelescope.wwt-user-website?branchName=master)](https://dev.azure.com/aasworldwidetelescope/WWT/_build/latest?definitionId=1&branchName=master)
[![Powered by NumFOCUS](https://img.shields.io/badge/powered%20by-NumFOCUS-orange.svg?style=flat&colorA=E1523D&colorB=007D8A)](http://numfocus.org)

# The worldwidetelescope.org “user” website

The user-facing portion of the
[WorldWide Telescope](https://worldwidetelescope.org/home/) (WWT) website:

### https://worldwidetelescope.org/home/

This includes the static user-facing pages but not the
[web client](https://github.com/worldwidetelescope/wwt-web-client) or the
[legacy API](https://github.com/worldwidetelescope/wwt-website) or the
[Communities](https://github.com/worldwidetelescope/wwt-website) component of
the web app.

You can monitor metrics for the WWT web services on [the public WWT metrics
dashboard][dashboard], made possible by support from [Datadog].

[dashboard]: https://p.us3.datadoghq.com/sb/cf4ddee0-e5ae-11ec-90f8-da7ad0900003-c64423f0e5e0627e2eb777abe3e591b0
[Datadog]: https://datadoghq.com/

Learn more about WWT [here](https://worldwidetelescope.org/home/).

[//]: # (numfocus-fiscal-sponsor-attribution)

The WorldWide Telescope project uses an [open governance
model](https://worldwidetelescope.org/about/governance/) and is fiscally
sponsored by [NumFOCUS](https://numfocus.org/). Consider making a
[tax-deductible donation](https://numfocus.org/donate-for-worldwide-telescope)
to help the project pay for developer time, professional services, travel,
workshops, and a variety of other needs.

<div align="center">
  <a href="https://numfocus.org/donate-for-worldwide-telescope">
    <img height="60px"
         src="https://raw.githubusercontent.com/numfocus/templates/master/images/numfocus-logo.png">
  </a>
</div>


## Quick Start for the Initiated

This site is written in [CommonMark Markdown] and processed with [Zola]. Zola
is distributed as a single executable so it is ridiculously
[easy to install][install-zola]. Once you have Zola all you have to do is run

```
zola serve
```

to build the site and serve it locally for testing. The command `zola check`
will check the build and verify that outgoing links are valid. Zola has
[lots of documentation][zola-docs].

[CommonMark Markdown]: https://commonmark.org/
[Zola]: https://getzola.org/
[install-zola]: https://www.getzola.org/documentation/getting-started/installation/
[zola-docs]: https://www.getzola.org/documentation/getting-started/overview/

Merges to `master` will be published automatically using WWT’s continuous
deployment infrastructure.


## URL structure

The files in this repository drive the following URL paths:

- `/about`
- `/assets`
- `/connect`
- `/download`
- `/home`
- `/learn`
- `/style.css`
- `/terms`
- `/use`

Note that the root path `/` is handled specially in WWT: users are redirected
either to `/webclient/` or `/home/` depending on a preference cookie.

Routing in the reverse proxy is case-insensitive, as were the URLs in the
original app backed, so the generated website provides numerous capitalized
aliases to the above too.


## Contributing

Contributions are welcome! If you’re new to the project, please see the
[WWT Contributors’ Guide] and the [WWT Code of Conduct]. We operate with a
standard [fork-and-pull] model.

[WorldWide Telescope User Manual]: https://docs.worldwidetelescope.org/user-docs-hub/
[WWT Contributors’ Guide]: https://worldwidetelescope.github.io/contributing/
[WWT Code of Conduct]: https://worldwidetelescope.github.io/code-of-conduct/
[fork-and-pull]: https://help.github.com/en/articles/about-collaborative-development-models


## Acknowledgments

Work on the WorldWide Telescope system has been supported by the [American
Astronomical Society] (AAS), the [.NET Foundation], and other partners. See [the
WWT user website][acks] for details.

[American Astronomical Society]: https://aas.org/
[.NET Foundation]: https://dotnetfoundation.org/
[acks]: https://worldwidetelescope.org/about/acknowledgments/


## Legalities

The WWT code is licensed under the [MIT License]. The copyright to the code is
owned by the [.NET Foundation].

[MIT License]: https://opensource.org/licenses/MIT
