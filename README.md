# The worldwidetelescope.org “user” website

The user-facing portion of the [AAS](https://aas.org/)
[WorldWide Telescope](https://worldwidetelescope.org/home/) (WWT) website:

### https://worldwidetelescope.org/home/

This includes the static user-facing pages but not the
[web client](https://github.com/worldwidetelescope/wwt-web-client) or the
[API](https://github.com/worldwidetelescope/wwt-website) or the
[Communities](https://github.com/worldwidetelescope/wwt-website) component of
the web app.

Learn more about WWT [here](https://worldwidetelescope.org/home/).


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
- `/terms`
- `/use`

Note that the root path `/` is handled specially in WWT: users are redirected
either to `/webclient/` or `/home/` depending on a preference cookie.


## Contributing

Contributions are welcome! If you’re new to the project, please see the
[WWT Contributors’ Guide] and the [WWT Code of Conduct]. We operate with a
standard [fork-and-pull] model.

[AAS WorldWide Telescope User Manual]: https://docs.worldwidetelescope.org/user-docs-hub/
[WWT Contributors’ Guide]: https://worldwidetelescope.github.io/contributing/
[WWT Code of Conduct]: https://worldwidetelescope.github.io/code-of-conduct/
[fork-and-pull]: https://help.github.com/en/articles/about-collaborative-development-models


## Acknowledgments

The AAS WorldWide Telescope system is a [.NET Foundation] project managed by
the non-profit [American Astronomical Society] (AAS). Work on WWT has been
supported by the AAS, the US [National Science Foundation] (grants [1550701]
and [1642446]), the [Gordon and Betty Moore Foundation], and [Microsoft].

[.NET Foundation]: https://dotnetfoundation.org/
[American Astronomical Society]: https://aas.org/
[National Science Foundation]: https://www.nsf.gov/
[1550701]: https://www.nsf.gov/awardsearch/showAward?AWD_ID=1550701
[1642446]: https://www.nsf.gov/awardsearch/showAward?AWD_ID=1642446
[Gordon and Betty Moore Foundation]: https://www.moore.org/
[Microsoft]: https://www.microsoft.com/


## Legalities

The WWT code is licensed under the [MIT License]. The copyright to the code is
owned by the [.NET Foundation].

[MIT License]: https://opensource.org/licenses/MIT
