# NewsABGN

<프로젝트 개요>
  - “뉴스안볼꼬냥?“
  - 웹 크롤러와 API를 이용한 뉴스 스크랩 솔루션
  - 2019.06.17. - 2019.06.27
<프로젝트 목표>
  - 실무 환경과 유사한 3-Tier 구조를 이해하고 설계 및 구현을 달성한다.
  - 사용자 중심의 설계를 구현 할 수 있다.
  - OpenAPI 의 활용법에 대해 익힌다.
<프로젝트 범위>
  - DB<MySQL>: 관계가 잡혀있는 유저 정보, 기사 스크랩 목록, 키워드 목록 저장
  - Logic<C#>: DB 서버를 조작할 Entity Framework 및 UI 컨트롤 로직
  - Logic<Python>: 뉴스 기사 검색, 조회, 크롤링 역할 설계 및 분석
  - UI<C#-winform>: GUI 제작
  
<프로젝트 환경>
 하드웨어 자원
  - 노트북 (삼성 NT371B5L)
  - Google Cloud Platform
 소프트웨어 자원
  - Visual Studio
  - PyCharm
  - GitHub
  - Trello
  - MySQL
  
 주요 언어 : C#, Python
  
  [Application Layer]
1. Windows Application (Winform)
2. Windows Form Control

[Business Logic Layer]
1. C# DB Logic
2. Python 데이터 크롤링
3. Python 뉴스 전문 크롤링
4. Naver Rest API 뉴스기사 검색
5. 실시간 검색어 추출 (HTML Parser)

[DataBase Resorces Layer]
1. C# Entity Framework ORM
2. Google Cloud Platform
3. Windows NT Server
4. MSSQL Server 2017

<추후 개선 사항>
Known Bug
 - C# 인코딩 이슈로 본문보기 버튼시, 간헐적으로 안나오는 현상 발생
 
UI
 - 디자인 : Windows 창조절, 반응형으로 전체 컨트롤 제어 미흡
 - 디자인 : 이미지 버튼 hover 시, 눈에 띄게 출력.
 - 뉴스 전문 가독성 있게 Parsing 필요.

Logic & Control
 - 비동기 방식 (Async Await) 의 활용 방안 모색 후, <연관 키워드> 추출 시, Progress Bar Control 생성 필요.
 - Search 결과가 NaverApi 특성상, 가져올 수 있는 결과 수 제한
 
AI
 - 인공지능 감정분석을 통한 기사 반응 예측

배포
 - Python 인터프리터 & 사이트패키지를 DLL로 가공 후 배포 필요.
