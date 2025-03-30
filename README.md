# DeterministicDouble
 tolerance를 고려한 산술, 비교, 변환, 반올림 기능을 제공하는 결정성 있는 double
 
# 설명
- tolerance 기반 비교 : Approximately 메서드를 사용하여 두 값의 차이가 값의 크기에 따른 허용 오차(tolerance) 내에 있을 경우 동일하다고 판단합니다.
- 사칙연산 지원: 덧셈, 뺄셈, 곱셈, 나눗셈 연산자 오버로딩을 통해 자연스러운 산술 연산을 수행할 수 있습니다.
- 변환 기능: 암시적 변환 연산자를 통해 double, float, decimal 등 다양한 수치 타입과의 상호 변환을 지원하며, 명시적 변환으로 다른 타입으로의 변환도 제공합니다.
- 정밀도 및 반올림 기능: Round 메서드를 통해 지정한 자릿수로 반올림하여 결과의 정밀도를 조절할 수 있습니다.
- 인터페이스 구현: IComparable 및 IEquatable 인터페이스를 구현하여 컬렉션 내 정렬 및 검색 시 tolerance를 반영한 비교를 가능하게 합니다.
