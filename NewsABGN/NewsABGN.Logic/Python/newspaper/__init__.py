# -*- coding: utf-8 -*-
"""
Wherever smart people work, doors are unlocked. -- Steve Wozniak
"""
__title__ = 'newspaper'
__author__ = 'Lucas Ou-Yang'
__license__ = 'MIT'
__copyright__ = 'Copyright 2014, Lucas Ou-Yang'

from .api import (build, build_article, fulltext, hot, languages,
                  popular_urls, Configuration as Config)
from .article import Article, ArticleException
from .mthreading import NewsPool
from .source import Source
from .version import __version__

news_pool = NewsPool()

# Set default logging handler to avoid "No handler found" warnings.
import logging

try:  # Python 2.7+
    from logging import NullHandler
except ImportError:
    class NullHandler(logging.Handler):
        def emit(self, record):
            pass

logging.getLogger(__name__).addHandler(NullHandler())

from os.path import dirname, basename, isfile, join
import glob
modules = glob.glob(join(dirname(__file__), "*.py"))
__all__ = [ basename(f)[:-3] for f in modules if isfile(f) and not f.endswith('__init__.py')]