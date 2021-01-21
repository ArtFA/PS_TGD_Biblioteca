----------- The Guardian Dog Studio Library -----------

Scripts:

- TGDMouse.cs -> Possui fun��es que envolvem checar a posi��o do mouse.

- TGDCamera.cs -> Possui fun��es que envolvem o controle da c�mera.

- TGDMath.cs -> Possui fun��es relacioandas � matem�tica e vetores.

- TGDUi.cs -> Possui fun��es para cria��o de interfaces.

-------------------------------------------------------

Usabilidade das fun��es:
-TGDMouse:
	1. positionOnScene()
		� Retorna um vetor de 2 dimens�es (Vector2) com a posi��o do mouse em rela��o ao que se encontra na cena.
		� Pode ser chamada de qualquer lugar.
		� Exemplo: TGDMouse.positionOnScene().

	2. positionOnScreen()
		� Retorna um vetor de 2 dimens�es (Vector2) com a posi��o do mouse em rela��o ao que se encontra na UI (espa�o vis�vel na tela).
		� Pode ser chamada de qualquer lugar.
		� Exemplo: TGDMouse.positionOnScreen().

	3. isHittingObject()
		� Retorna true (bool) se o mouse est� sobre um objeto.
		� Pode ser chamada de qualquer lugar.
		� Exemplo: TGDMouse.isHittingObject().


-TGDCamera:
	4. shake(float duration, float magnitude)
		� Treme a c�mera passando os par�metros de dura��o (duration) e a intensidade (magnitude).
		� Dura��o e magnitude do tremor devem ser valores positivos.
		� Pode ser chamada de qualquer lugar, desde que o Script TGDCamera seja componente da c�mera principal.
		� Exemplo: TGDCamera.shake(1, 0.4f).


-TGDMath:
	5. random(float min, float max)
		� Retorna um n�mero (float) aleat�rio passando um intervalo.
		� Pode ser chamada de qualquer lugar.
		� Exemplo: TGDMath.random(0, 10).

	6. randomVector(float minX, float maxX, float minY, float maxY)
		� Retorna um vetor de 2 dimens�es (Vector2) de forma aleat�ria passando intervalos para cada dimens�o.
		� Pode ser chamada de qualquer lugar.
		� Exemplo: TGDMath.randomVector(-10, 10, -20, 20).

	7. angleBetweenPlanes(Plane plane1, Plane plane2)
		� Retorna um �ngulo (float), em graus, entre 2 planos em 2 dimens�es.
		� Pode ser chamada de qualquer lugar.
		� Exemplo: TGDMath.angleBetweenPlanes(new Plane(new Vector3(10, 0, 0), 20), new Plane(new Vector3(0, 10, 0), 20)).

	8. rotateVector(Vector2 vector, float angle)
		� Aplica uma rota��o em um vetor de 2 dimens�es. Retorna o vetor (Vector2) rotacionado.
		� �ngulo de rota��o deve ser especificado em graus.
		� Pode ser chamada de qualquer lugar.
		� Exemplo: TGDMath.rotateVector(new Vector2(10,0), 90).

	9. generateNormalizedVector()	
		� Retorna um vetor de 2 dimens�es (Vector2) alet�rio normalizado.
		� Pode ser chamada de qualquer lugar.
		� Exemplo: TGDMath.generateNormalizedVector().


-TGDUi:
	10. displayText(string txt, float x, float y)
		� Faz um texto ser apresentado na tela, passando um vetor de 2 (duas) posi��es.
		� Se um texto for instanciado na mesma posi��o que outro, o anterior ser� removido. Isso possibilita o acompanhamento de vari�veis em tempo real (se a fun��o for chamada no m�todo Update, 
		por exemplo, os textos n�o v�o ficar se sobrepondo e prejudicando a leitura).
		� Pode ser chamada de qualquer lugar.
		� Exemplo: TGDUi.displayText("O nome dele � Chico", new Vector2(30, -30)).

-------------------------------------------------------