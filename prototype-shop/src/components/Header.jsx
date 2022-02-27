export default function Header() {
  return (
    <header>
      <div className="header__container">
        <div className="title">Awesome Prototypes in Shop</div>
        <div className="subtitle">
        다른 디자이너가 ProtoPie를 이용하여 만든 디자인을 확인하세요.
        예제를 다운로드 하여 자세히 알아볼수 있습니다.
        </div>
        <div className="btn__area">
          <a href="https://www.protopie.io" target="_BLANK" rel="noreferrer">
            <button>Try ProtoPie Yourself</button>
          </a>
        </div>
      </div>
    </header>
  );
}