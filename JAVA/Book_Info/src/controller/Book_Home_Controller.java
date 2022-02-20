package controller;

import java.util.ArrayList;
import java.util.Scanner;

import dto.Book_VO;
import dto.Book_System_VO;
import dao.Book_DAO;
import service.Book_Service;

public class Book_Home_Controller {
	public static void main(String[] args) {
		ArrayList<Book_VO> dtos;
		Book_Service service = new Book_Service();
		int choice = 0;
		int choice1 = 0;
		String NAME, AUTHOR, PUBLISHER, LIBRARY, REFERENCE_LIBRARY, BOOK_SYMBOL, LOAN;
		int PUBLISHING_DATE, KDC;
		String id = "";
		String password = "";
		boolean isLoggedIn = false;
		boolean isDuplicate = false;

		Scanner sc = new Scanner(System.in);
		while (true) {
			Mainmenu();
			choice = sc.nextInt();
			if (choice == 1) {
				while (true) {
					SearchMenu();
					choice1 = sc.nextInt();
					if (choice1 == 1) {
						dtos = service.getAllBook();
						for (int i = 0; i < dtos.size(); i++) {
							System.out.printf("제목:%s\n", dtos.get(i).getName());
							System.out.printf("작가:%s\n", dtos.get(i).getAuthor());
							System.out.printf("출판사:%s\n", dtos.get(i).getPublisher());
							System.out.printf("출판년도:%d\n", dtos.get(i).getPublishing_Date());
							System.out.printf("도서관:%s\n", dtos.get(i).getLibrary());
							System.out.printf("자료실:%s\n", dtos.get(i).getPeference_Library());
							System.out.printf("도서번호:%s\n", dtos.get(i).getBook_Symbol());
							System.out.printf("KDC넘버:%d\n", dtos.get(i).getKdc());
							System.out.printf("대출여부:%s\n", dtos.get(i).getLoan());
							System.out.print("------------------------------------\n");
						}dtos.clear();
					} else if (choice1 == 2) {
						System.out.print("제목 입력: ");
						sc.nextLine();
						NAME = sc.nextLine();
						System.out.print("----------------------------------------------\n");
						dtos = service.SearchNAME(NAME);
						for (int i = 0; i < dtos.size(); i++) {
							System.out.printf("제목:%s\n", dtos.get(i).getName());
							System.out.printf("작가:%s\n", dtos.get(i).getAuthor());
							System.out.printf("출판사:%s\n", dtos.get(i).getPublisher());
							System.out.printf("출판년도:%d\n", dtos.get(i).getPublishing_Date());
							System.out.printf("도서관:%s\n", dtos.get(i).getLibrary());
							System.out.printf("자료실:%s\n", dtos.get(i).getPeference_Library());
							System.out.printf("도서번호:%s\n", dtos.get(i).getBook_Symbol());
							System.out.printf("KDC넘버:%d\n", dtos.get(i).getKdc());
							System.out.printf("대출여부:%s\n", dtos.get(i).getLoan());
							System.out.print("----------------------------------------------\n");
						}
						dtos.clear();

					} else if (choice1 == 3) {

						dtos = service.SearchLOAN();
						for (int i = 0; i < dtos.size(); i++) {
							System.out.printf("제목:%s\n", dtos.get(i).getName());
							System.out.printf("작가:%s\n", dtos.get(i).getAuthor());
							System.out.printf("출판사:%s\n", dtos.get(i).getPublisher());
							System.out.printf("출판년도:%d\n", dtos.get(i).getPublishing_Date());
							System.out.printf("도서관:%s\n", dtos.get(i).getLibrary());
							System.out.printf("자료실:%s\n", dtos.get(i).getPeference_Library());
							System.out.printf("도서번호:%s\n", dtos.get(i).getBook_Symbol());
							System.out.printf("KDC넘버:%d\n", dtos.get(i).getKdc());
							System.out.printf("대출여부:%s\n", dtos.get(i).getLoan());
							System.out.print("----------------------------------------------\n");
						}
						dtos.clear();
					} else if (choice1 == 4) {
						System.out.print("도서관 검색(중앙,인동,봉곡): ");
						LIBRARY = sc.next();
						dtos = service.SearchLIBRARY(LIBRARY);
						for (int i = 0; i < dtos.size(); i++) {
							System.out.printf("제목:%s\n", dtos.get(i).getName());
							System.out.printf("작가:%s\n", dtos.get(i).getAuthor());
							System.out.printf("출판사:%s\n", dtos.get(i).getPublisher());
							System.out.printf("출판년도:%d\n", dtos.get(i).getPublishing_Date());
							System.out.printf("도서관:%s\n", dtos.get(i).getLibrary());
							System.out.printf("자료실:%s\n", dtos.get(i).getPeference_Library());
							System.out.printf("도서번호:%s\n", dtos.get(i).getBook_Symbol());
							System.out.printf("KDC넘버:%d\n", dtos.get(i).getKdc());
							System.out.printf("대출여부:%s\n", dtos.get(i).getLoan());
							System.out.print("----------------------------------------------\n");
						}
						dtos.clear();

					} else if (choice1 == 5) {
						System.out.print("도서관 검색(중앙,인동,봉곡): ");
						LIBRARY = sc.next();
						System.out.print("자료실 검색(종합,아동,유아,인문): ");
						REFERENCE_LIBRARY = sc.next();
						System.out.print("----------------------------------------------\n");

						dtos = service.SearchREFERENCE_LIBRARY(LIBRARY, REFERENCE_LIBRARY);
						for (int i = 0; i < dtos.size(); i++) {
							System.out.printf("제목:%s\n", dtos.get(i).getName());
							System.out.printf("작가:%s\n", dtos.get(i).getAuthor());
							System.out.printf("출판사:%s\n", dtos.get(i).getPublisher());
							System.out.printf("출판년도:%d\n", dtos.get(i).getPublishing_Date());
							System.out.printf("도서관:%s\n", dtos.get(i).getLibrary());
							System.out.printf("자료실:%s\n", dtos.get(i).getPeference_Library());
							System.out.printf("도서번호:%s\n", dtos.get(i).getBook_Symbol());
							System.out.printf("KDC넘버:%d\n", dtos.get(i).getKdc());
							System.out.printf("대출여부:%s\n", dtos.get(i).getLoan());
							System.out.print("----------------------------------------------\n");
						}
						dtos.clear();
					} else if (choice1 == 6) {
						break;
					}
				}

			} else if (choice == 2) {
				System.out.println("관리자 계정 로그인");
				System.out.print("-----------------\n");
				System.out.print("아이디 입력:");
				id = sc.next();
				System.out.print("비밀번호 입력:");
				password = sc.next();
				int loginCheckRet = service.loginCheck(id, password);
				if (loginCheckRet == 1) {
					System.out.println("관리자 로그인성공!");
					isLoggedIn = true;// 로그인 상태 유지
					while (true) {
						menu();
						choice = sc.nextInt();
						if (choice == 1) {
							System.out.println("추가할 도서 정보 입력");
							System.out.print("제목입력 : ");
							sc.nextLine();
							NAME = sc.nextLine();
							System.out.print("작가입력 : ");
							AUTHOR = sc.nextLine();
							System.out.print("출판사입력 : ");
							PUBLISHER = sc.next();
							System.out.print("출판년도입력 : ");
							PUBLISHING_DATE = sc.nextInt();
							System.out.print("도서관입력 : ");
							LIBRARY = sc.next();
							System.out.print("자료실입력 : ");
							REFERENCE_LIBRARY = sc.next();
							System.out.print("도서번호입력 : ");
							BOOK_SYMBOL = sc.next();
							System.out.print("KDC넘버입력 : ");
							KDC = sc.nextInt();
							System.out.print("대출여부 : ");
							LOAN = sc.next();
							service.InsertBook(NAME, AUTHOR, PUBLISHER, PUBLISHING_DATE, LIBRARY, REFERENCE_LIBRARY,
									BOOK_SYMBOL, KDC, LOAN);							
						} else if (choice == 2) {
							System.out.print("수정할 도서 제목 입력: ");
							sc.nextLine();
							NAME = sc.nextLine();
							System.out.print("수정할 도서의 도서관입력: ");
							LIBRARY = sc.next();
							System.out.print("대출상태 변경: ");
							LOAN = sc.next();
							service.UpdateLOAN(NAME, LIBRARY, LOAN);

						} else if (choice == 3) {
							System.out.print("삭제할 도서 제목 입력 : ");
							sc.nextLine();
							NAME = sc.nextLine();
							System.out.print("삭제할 도서의 도서관 입력 : ");
							LIBRARY = sc.next();
							service.DeleteBook(NAME, LIBRARY);
						} else if (choice == 4) {
							System.out.print("종료!\n");
							break;
						}
					}

				} else if (loginCheckRet == 0) {
					System.out.println("아이디 또는 비밀번호가 잘못 입력 되었습니다.");
				} else if (loginCheckRet == -1) {
					System.out.println("아이디가 존재하지 않습니다!");
				}
			} else if (choice == 3) {
				break;
			}
		}
	}

	public static void Mainmenu() {
		System.out.println("1.도서정보 조회");
		System.out.println("2.관리자메뉴");
		System.out.println("3.종료");
	}

	public static void SearchMenu() {
		System.out.println("1.도서정보 모두 조회");
		System.out.println("2.도서제목 검색");
		System.out.println("3.대출가능 도서 조회");
		System.out.println("4.도서관 조회");
		System.out.println("5.자료실 조회");
		System.out.println("6.상위메뉴로 이동");

	}

	public static void menu() {
		System.out.println("1.도서정보 추가");
		System.out.println("2.도서정보 수정");
		System.out.println("3.도서정보 삭제");
		System.out.println("4.종료");
	}
}
