import requests
from bs4 import BeautifulSoup
import codecs
import operator
import urllib.request
import urllib.parse


# get newlist from '_keyword' search / for amount: '_pageMax' pages / return article_list
def news_list_extractor(_keyword, _pageMax):
    article_list = []
    for page in range(_pageMax):
        i = page * 10 + 1
        # print("Fetching page: " + str(page+1) + "...   ", end="")
        queryUrl = "https://search.naver.com/search.naver?&where=news&query="+_keyword+"&sm=tab_pge&sort=0&photo=0&field=0&reporter_article=&pd=0&ds=&de=&docid=&nso=so:r,p:all,a:all&mynews=0&cluster_rank=60&start="+str(i)+"&refresh_start=0"
        query = requests.get(queryUrl, headers={'User-Agent': 'Mozilla/5.0'}).text
        html = BeautifulSoup(query, "html.parser")
        articles = html.find_all('dd', attrs={"class", "txt_inline"})

        for article in articles:
            if article.find('a')['href'] != "#":
                article_list += [article.find('a')['href']]
        # print("Done!")
    # print("News url list build complete.")
    return article_list


# given html info(f12) return title and body text as list of words / return title, body
def get_title_body_soup(soup):
    # Sports
    title = soup.find_all('h4', attrs={'class', 'title'})
    body = [soup.find('div', id="newsEndContents")]

    # Entertainment
    if title == [] or body == []:
        title = soup.find_all('h2', attrs={'class', 'end_tit'})
        body = [soup.find('div',  id='articeBody')]

    # Else (politics...)
    if title == [] or body == []:
        title = [soup.find('h3', id="articleTitle")]
        body = [soup.find('div', id='articleBodyContents')]

    if title != [] and body != []:
        try:
            script = body[0].find('script')
            if script is not None:
                script.decompose()
        except AttributeError:
            return [], []

    title = title[0].text.strip().replace("[", " ").replace("]", " ").replace("\"", " ").replace("\'", " ").split()
    body = body[0].text.strip().replace("\n", " ").replace("  ", " ").replace("[", " ").replace("]", " ").replace("\"", " ").replace("\'", " ").split()

    return title, body


# given article_list return word list of all words of titles and body contents / return word_list
def make_word_list_soup(article_list):
    word_list = []
    i = 1
    # print("---Making word pool (Soup)---")
    for article in article_list:
        # print("processing..." + str(i) + "/" + str(len(article_list)), end="")
        i += 1

        with urllib.request.urlopen(article) as response:
            html_f12 = response.read()
            soup = BeautifulSoup(html_f12, 'html.parser')

            title, body = get_title_body_soup(soup)

        if title == [] or body == []:
            # print("Passed: " + article + "\n")
            continue

        word_list += title + body
        # print("...added: " + str(len(title) + len(body)) + " word... from " + article, end='')
        # print(" ... Done!")
    # print("Word list build complete")
    return word_list


# given a keyword, save appropriate words to a txt file
def news_word_extractor(_keyword, _page_max, _output_file):
    # =============뉴스 리스트 크롤링=======================================================================================

    article_list = news_list_extractor(_keyword, _page_max)

    # =============각 뉴스 크롤링 & 단어 추출===============================================================================
    word_list = make_word_list_soup(article_list)

    word_list_return = []
    exclude_list = ['구독', '기자', '뉴스', '네이버', '사진', '무단', '배포', '금지', '기사제공', '있다', '있고', '있는', '있다.', '대한',
                    '이런', '이날', '지난', '대해', '통해']
    
    # print words to a txt file: a word per line
    # out_file = codecs.open(_output_file, 'a', encoding='utf8')
    for word in word_list:
        if word in exclude_list:   # 제외 단어
            continue
        if _keyword in word:
            continue
        if len(word) < 2:   # 한 글자 제외
            continue
        word_list_return += [word]
        # out_file.write(word + "\n")
    # out_file.close()

    return word_list_return


# from 'file_to_open' read line by line and print 'top_n' words that appears most frequently
def extract_top_n(word_list, top_n ):

    word_dict = {}
    count = 0

    for word in word_list:
        if word in word_dict:
            word_dict[word] += 1
        else:
            word_dict[word] = 1
    
    sorted_dict = sorted(word_dict.items(), key=operator.itemgetter(1))
    print(sorted_dict[-top_n:])


# start
import sys

keyword = sys.argv[1]
extract_top_n(news_word_extractor(keyword, 10, "test_"+keyword+".txt"), 30)