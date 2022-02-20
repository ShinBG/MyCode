package Controller;

import java.util.ArrayList;
import java.util.Scanner;

import dto.UsedCar_VO;
import service.UsedCar_Service;

public class HomeController {
	
	public static void main(String[] args) 
	{
		Scanner sc = new Scanner(System.in);
		ArrayList<UsedCar_VO> dtos;
		UsedCar_Service service = new UsedCar_Service();
		int choice = 0;
		String company, name, color, engine, accident, buy_date;
		int price, km;
		while(true)
		{
			menu();
			choice = sc.nextInt();
			if(choice==1) {//전체 검색
				dtos=service.getAllMembers();
				for(int i=0; i<dtos.size(); i++) {
					System.out.printf("제조사명:%s  ", dtos.get(i).getCOMPANY());
					System.out.printf("차량 모델명:%s ", dtos.get(i).getNAME());
					System.out.printf("가격:%d원 ", dtos.get(i).getPRICE());
					System.out.printf("주행거리:%dkm ", dtos.get(i).getKM());
					System.out.printf("색깔:%s ", dtos.get(i).getCOLOR());
					System.out.printf("엔진 종류:%s ", dtos.get(i).getENGINE());
					System.out.printf("사고유무:%s ", dtos.get(i).getACCIDENT());
					System.out.printf("구매일:%s \n", dtos.get(i).getDATE());
				}
				dtos.clear();
				System.out.println("");
			}
			else if(choice==2) {
				int min, max;
				System.out.println("최소가격:");
				min=sc.nextInt();
				System.out.print("최대가격");
				max=sc.nextInt();
				dtos=service.BetweenSearchCar(min, max);
				for(int i=0; i<dtos.size(); i++) {
					System.out.printf("제조사명:%s  ", dtos.get(i).getCOMPANY());
					System.out.printf("차량 모델명:%s ", dtos.get(i).getNAME());
					System.out.printf("가격:%d원 ", dtos.get(i).getPRICE());
					System.out.printf("주행거리:%dkm ", dtos.get(i).getKM());
					System.out.printf("색깔:%s ", dtos.get(i).getCOLOR());
					System.out.printf("엔진 종류:%s ", dtos.get(i).getENGINE());
					System.out.printf("사고유무:%s", dtos.get(i).getACCIDENT());
					System.out.printf("구매일:%s\n", dtos.get(i).getDATE());
				}
				dtos.clear();
			}
			else if(choice==3) { //차량 추가
				System.out.print("제조사명 입력:");
				sc.nextLine();
				company=sc.nextLine();
				System.out.print("차량 모델명 입력:");
				name=sc.next();
				System.out.print("가격 입력:");
				price=sc.nextInt();
				System.out.print("주행거리 입력:");
				km=sc.nextInt();
				System.out.print("색깔 입력:");
				color=sc.next();
				System.out.print("엔진종류 입력:");
				engine=sc.next();
				System.out.print("사고유무 입력:");
				accident=sc.next();
				System.out.print("구매일 입력:");
				buy_date=sc.next();
				service.setMembers(company, name, price, km, color, engine, accident, buy_date);
			}
			else if(choice==4) {
				System.out.print("차량 모델명 입력:");
				sc.nextLine();
				name=sc.nextLine();
				System.out.print("수정할 가격 입력:");
				price=sc.nextInt();
				service.UpdateCarPrice(name, price);
			}
			else if(choice==5) {
				System.out.print("차량 모델명 입력:");
				name=sc.next();
				service.DeleteCar(name);
			}
			else if(choice==6) {
				System.out.println("차량 모델명 입력:");
				name=sc.next();
				dtos=service.SearchCar(name);
				for(int i=0; i<dtos.size(); i++) {
					System.out.printf("제조사명:%s  ", dtos.get(i).getCOMPANY());
					System.out.printf("차량 모델명:%s ", dtos.get(i).getNAME());
					System.out.printf("가격:%d원 ", dtos.get(i).getPRICE());
					System.out.printf("주행거리:%dkm ", dtos.get(i).getKM());
					System.out.printf("색깔:%s ", dtos.get(i).getCOLOR());
					System.out.printf("엔진 종류:%s ", dtos.get(i).getENGINE());
					System.out.printf("사고유무:%s", dtos.get(i).getACCIDENT());
					System.out.printf("구매일:%s\n", dtos.get(i).getDATE());
				}
				dtos.clear();
			}
			else if(choice==7) {
				break;
			}
		}
	}
	
	public static void menu() {
		System.out.println("1.모든 중고차 조회");
		System.out.println("2.조건 검색");
		System.out.println("3.중고차 추가");
		System.out.println("4.중고차 수정");
		System.out.println("5.중고차 삭제");
		System.out.println("6.차량 모델명 검색");
		System.out.println("7.종료");
	}
}