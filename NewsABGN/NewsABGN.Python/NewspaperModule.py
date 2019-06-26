
from newspaper import Article
import sys

urls = []

# UI에서 선택된 기사 URL
urls += [sys.argv[1]]

# for Console test
#urls += ['http://www.kookje.co.kr/news2011/asp/newsbody.asp?code=0600&key=20190608.99099003529']

for url in urls:
    article = Article(url, language='ko')
    article.download()
    article.parse()
    print(article.title)
    print(article.text)
