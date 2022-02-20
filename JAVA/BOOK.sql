--------------------------------------------------------
--  DDL for Table BOOK
--------------------------------------------------------

  CREATE TABLE "SYSTEM"."BOOK" 
   (	"NAME" VARCHAR2(200 BYTE), 
	"AUTHOR" VARCHAR2(50 BYTE), 
	"PUBLISHER" VARCHAR2(50 BYTE), 
	"PUBLISHING_DATE" NUMBER, 
	"LIBRARY" VARCHAR2(30 BYTE), 
	"REFERENCE_LIBRARY" VARCHAR2(50 BYTE), 
	"BOOK_SYMBOL" VARCHAR2(50 BYTE), 
	"KDC" NUMBER, 
	"LOAN" VARCHAR2(15 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into SYSTEM.BOOK
SET DEFINE OFF;
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('나는 잠자는 동안에도 해외주식으로 돈 번다','주이슬','굿웰스북스',2021,'구미시인동도서관','[인동]종합자료실','327.856-주이슬ㄴ',327.856,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(바이오 투자 레전드 황만순의) 대한민국 바이오투자:바이오,반도체를 넘보다','황만순','리치캠프',2021,'구미시인동도서관','[인동]종합자료실','327.856-황만순ㄷ',327.856,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('불편한 편의점:김호연 장편소설','김호연','나무옆의자',2021,'구미시인동도서관','[인동]종합자료실','813.6-김호연ㅂ',813.6,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('영매탐정 조즈카','아이자와 사코','비채',2021,'구미시인동도서관','[인동]종합자료실','833.6-아이자ㅇㄱ',833.6,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('과학 탐정스 1,신비도의 비밀','조인하 글 , 조승연 그림','미래엔',2021,'구미시인동도서관','[인동]아동자료실','아400-과학탐-1',400,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('맹탐정 고민 상담소:이선주 장편소설','이선주','문학동네',2019,'구미시인동도서관','[인동]종합자료실','813.6-이선주ㅁ=3',813.6,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('엄마를 꿀꺽한 멍청이늑대','노부미','길벗어린이',2017,'구미시인동도서관','[인동]유아자료실','유833.6-노부미ㅇㄱ',833.6,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('안녕,겨울아','어린이 통합교과 연구회','루크하우스',2013,'구미시인동도서관','[인동]유아자료실','유080-어린이-17',80,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('틀려도 괜찮아','마키다 신지','토토북',2006,'구미시인동도서관','[인동]유아자료실','유375.1-마키다ㅌㅇ=3',375.1,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('세종 대왕','김선희','비룡소',2009,'구미시인동도서관','[인동]유아자료실','아990-새싹인-11=2',990,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('친구를 만났어요','장 루 크레포','베틀북',2001,'구미시인동도서관','[인동]유아자료실','유863-크레포ㅊㅇ',863,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('Why?)생체 모방','파피루스','예림당',2020,'구미시인동도서관','[인동]아동자료실','아408-why-98',408,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('수상한 기차역','박현숙','북멘토',2021,'구미시인동도서관','[인동]아동자료실','아813.6-박현숙ㅅ',813.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('위기의 시대,돈의 미래','짐 로저스','리더스북',2020,'구미시인동도서관','[인동]종합자료실','321.97-로저스ㅇㅈ',321.97,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('그녀는 다 계획이 있다','히가시노 게이고','하빌리스',2021,'구미시인동도서관','[인동]종합자료실','833.6-히가시ㄱㅇ',833.6,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('살인 현장은 구름 위','히가시노 게이고','재인',2019,'구미시인동도서관','[인동]종합자료실','833.6-히가시ㄱㅇ',833.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('지하철 사고에서 살아남기 1','곰돌이co','아이세움',2020,'구미시인동도서관','[인동]아동자료실','아408-서바이-69',408,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('지하철 사고에서 살아남기 2','곰돌이co','아이세움',2020,'구미시인동도서관','[인동]아동자료실','아408-서바이-70',408,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('달까지 가자','장류진','창비',2021,'구미시립중앙도서관','[중앙]종합자료실','813.6-장류진ㄷ',813.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('그녀는 다 계획이 있다','히가시노 게이고','하빌리스',2021,'구미시립중앙도서관','[중앙]종합자료실','833.6-히가시ㄱㅇ',833.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('영매탐정 조즈카','아이자와 사코','비채',2021,'구미시립중앙도서관','[중앙]종합자료실','833.6-아이자ㅇㄱ',833.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('말투 하나로 의외로 잘 되기 시작했다','오시마 노부요리','위즈덤하우스',2019,'구미시립중앙도서관','[중앙]종합자료실','189-오시마ㅁㅈ',189,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('지옥 1','연상호,최규석','문학동네',2020,'구미시립중앙도서관','[중앙]종합자료실','810-연상호ㅈ-1',810,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('지옥 2','연상호,최규석','문학동네',2021,'구미시립중앙도서관','[중앙]종합자료실','810-연상호ㅈ-2',810,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('나빌레라 1','HUN,지민','위즈덤하우스 미디어그룹',2017,'구미시립중앙도서관','[중앙]종합자료실','818-훈ㄴ-1',818,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('나빌레라 2','HUN,지민','위즈덤하우스 미디어그룹',2017,'구미시립중앙도서관','[중앙]종합자료실','818-훈ㄴ-2',818,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('나빌레라 3','HUN,지민','위즈덤하우스 미디어그룹',2017,'구미시립중앙도서관','[중앙]종합자료실','818-훈ㄴ-3',818,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('나빌레라 4','HUN,지민','위즈덤하우스 미디어그룹',2017,'구미시립중앙도서관','[중앙]종합자료실','818-훈ㄴ-4',818,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('나빌레라 5','HUN,지민','위즈덤하우스 미디어그룹',2017,'구미시립중앙도서관','[중앙]종합자료실','818-훈ㄴ-5',818,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(소수몽키의 한 권으로 끝내는)미국주식','소수몽키','길벗',2021,'구미시립중앙도서관','[중앙]종합자료실','327.856-소수몽ㅁ',327.856,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(주식 거인들에게 배우는)잃지 않는 투자 원칙 49 : 주식 대가들의원금보전 투자 철학을 배운다!','김명환','스마트비즈니스',2021,'구미시립중앙도서관','[중앙]종합자료실','327.856-김명환ㅇ',327.856,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('그러라 그래:양희은 에세이','양희은','김영사',2021,'구미시립중앙도서관','[중앙]종합자료실','818-양희은ㄱ',818,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('흔한남매 1','흔한남매 원작','미래엔',2019,'구미시립중앙도서관','[중앙]아동자료실','아813.6-흔한남ㅎ-1',813.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('흔한남매 2','흔한남매 원작','미래엔',2019,'구미시립중앙도서관','[중앙]아동자료실','아813.6-흔한남ㅎ-2',813.6,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('흔한남매 3','흔한남매 원작','미래엔',2019,'구미시립중앙도서관','[중앙]아동자료실','아813.6-흔한남ㅎ-3',813.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(설민석의)세계사 대모험 1, 프랑스 혁명 속으로!','설민석','단꿈아이',2019,'구미시립중앙도서관','[중앙]아동자료실','아909-설민석ㅅ-1',909,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(설민석의)세계사 대모험 2, 히틀러의 두 얼굴','설민석','단꿈아이',2019,'구미시립중앙도서관','[중앙]아동자료실','아909-설민석ㅅ-2',909,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(설민석의)세계사 대모험 3, 독일 편 - 전쟁과 평화','설민석','단꿈아이',2019,'구미시립중앙도서관','[중앙]아동자료실','아909-설민석ㅅ-3',909,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(설민석의)세계사 대모험 4, 이탈리아 편-로마에서 생긴 일','설민석','단꿈아이',2020,'구미시립중앙도서관','[중앙]아동자료실','아909-설민석ㅅ-4',909,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(설민석의)세계사 대모험 5, 이탈리아 편-위기의 르네상스','설민석','단꿈아이',2020,'구미시립중앙도서관','[중앙]아동자료실','아909-설민석ㅅ-5',909,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('용구 삼촌','권정생','산하',2009,'구미시립중앙도서관','[중앙]유아자료실','유813.6-권정생ㅇ',813.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('내가 잡았어!','데이비드 위즈너','시공주니어',2018,'구미시립중앙도서관','[중앙]유아자료실','유843-위즈너ㄴ',843,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('멋진 사냥꾼 잠자리','안은영','천둥거인',2008,'구미시립중앙도서관','[중앙]유아자료실','유491.508-안은영ㅁ=3',491.508,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('채근담','홍자성','현암사',1997,'구미시립중앙도서관','[중앙]인문고전','199-홍차성ㅊㅅ2',199,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('흔한남매 1','흔한남매 원작','미래엔',2019,'구미시봉곡도서관','[봉곡]아동자료실','아813.8-흔한남ㅎ-1',813.8,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('흔한남매 2','흔한남매 원작','미래엔',2019,'구미시봉곡도서관','[봉곡]아동자료실','아813.8-흔한남ㅎ-2',813.8,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('흔한남매 3','흔한남매 원작','미래엔',2019,'구미시봉곡도서관','[봉곡]아동자료실','아813.8-흔한남ㅎ-3',813.8,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('고구려 1, 도망자을불','김진명','새움',2011,'구미시봉곡도서관','[봉곡]종합자료실','813.6-김진명ㄱ-1',813.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('고구려 2, 다가오는 전쟁','김진명','새움',2011,'구미시봉곡도서관','[봉곡]종합자료실','813.6-김진명ㄱ-2',813.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('고구려 3, 낙랑추출','김진명','새움',2011,'구미시봉곡도서관','[봉곡]종합자료실','813.6-김진명ㄱ-3',813.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('고구려 4, 사유와 무','김진명','새움',2011,'구미시봉곡도서관','[봉곡]종합자료실','813.6-김진명ㄱ-4',813.6,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('고구려 5 : 고국원왕, 백성의 왕','김진명','새움',2013,'구미시봉곡도서관','[봉곡]종합자료실','813.6-김진명ㄱ-5',813.6,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('설민석의 세계사 대모험 6, 미국 편-인디펜던스 데이','설민석','단꿈아이',2020,'구미시봉곡도서관','[봉곡]아동자료실','아909-설민석ㅅ-6',909,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('아몬드:손원평 장편소설','손원평','창비',2020,'구미시봉곡도서관','[봉곡]종합자료실','813.7-손원평ㅇ',813.7,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('존리의 금융문맹 탈출 : 대한민국 경제독립 프로젝트','존 리','베가북스',2020,'구미시봉곡도서관','[봉곡]종합자료실','327.8-존리ㅈ',327.8,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('존리의 부자되기 습관 : 대한민국 경제독립 액션 플랜','존 리','지식노마드',2020,'구미시봉곡도서관','[봉곡]종합자료실','327.04-존리ㅈㄱ',327.04,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(소수몽키의 한 권으로 끝내는)미국주식','소수몽키','길벗',2021,'구미시봉곡도서관','[봉곡]종합자료실','327.856-소수몽ㅎ',327.856,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(기초부터 탄탄하게 바로 써먹는) 가치투자 처음공부','이성수','이레미디어',2021,'구미시봉곡도서관','[봉곡]종합자료실','327.856-이성수ㄱ',327.856,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('하루 만에 수익 내는 실전 주식투자','강창권','길벗',2019,'구미시봉곡도서관','[봉곡]종합자료실','327.856-강창권ㅎ',327.856,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('주식투자 무작정 따라하기','윤재수','길벗',2020,'구미시봉곡도서관','[봉곡]종합자료실','327.856-윤채수ㅈ',327.856,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(허영만의) 주식 타짜','허영만','가디언',2020,'구미시봉곡도서관','[봉곡]종합자료실','327.856-허영만ㅈ',327.856,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(경제기사를 읽으면) 주식투자가 쉬워집니다.','박지수','메이트북스',2020,'구미시봉곡도서관','[봉곡]종합자료실','327.856-박지수ㅈ',327.856,'대출중');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('낯선 자의 일기','엘리 그리피스','나무옆의자',2021,'구미시립중앙도서관','[중앙]종합자료실','843-그리피ㄴㅂ',843,'대출가능');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('미드나잇 라이브러리','매트 헤이그','인플루엔셜',2021,'구미시립중앙도서관','[중앙]종합자료실','843-헤이그ㅁㄴ=2',843,'대출가능');
--------------------------------------------------------
--  Constraints for Table BOOK
--------------------------------------------------------

  ALTER TABLE "SYSTEM"."BOOK" ADD CONSTRAINT "LOAN_CK" CHECK (loan in('대출중','대출가능')) ENABLE;
