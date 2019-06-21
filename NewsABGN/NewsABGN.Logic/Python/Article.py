# -*- coding: utf-8 -*-
# config = {}
# config['py_lib_dir'] = 'D:\\python\\venv\\Lib\\site-packges'

from newspaper import Article
import sys
sys.path.append("../../../NewsABGN.Logic/Python")
print("Aaa")
#print(sys.path)
# urls = []
# # 글로벌 이코노믹스
# urls += ['http://news.g-enews.com/view.php?ud=2019061000011141379ecba8d8b8_1&md=20190610000338_K']
# # 민주신문
# urls += ['http://www.iminju.net/news/articleView.html?idxno=46043']
# # OSEN
# urls += ['http://www.osen.co.kr/article/G1111159338']
# # 서울경제
# urls += ['https://www.sedaily.com/NewsView/1VKC75LU3B']
# # 국제신문
# urls += ['http://www.kookje.co.kr/news2011/asp/newsbody.asp?code=0600&key=20190608.99099003529']
#
# # for url in urls:
# #     article = Article(url, language='ko')
# #     article.download()
# #     article.parse()
# #     print(article.title)
# #     #print(article.text)
#
# def get_title(url):
#     arti = Article(url, language = "ko")
#     arti.download()
#     arti.parse()
#     return arti.title
#
#
# def get_body(url):
#     arti = Article(url, language = 'ko')
#     arti.download()
#     arti.parse()
#     return arti.text
