----------- The Guardian Dog Studio Library -----------

Scripts:

- TGDMouse.cs -> Possui funções que envolvem checar a posição do mouse.

- TGDCamera.cs -> Possui funções que envolvem o controle da câmera.

- TGDMath.cs -> Possui funções relacioandas à matemática e vetores.

- TGDUi.cs -> Possui funções para criação de interfaces.

-------------------------------------------------------

Usabilidade das funções:
-TGDMouse:
	1. positionOnScene()
		• Retorna um vetor de 2 dimensões (Vector2) com a posição do mouse em relação ao que se encontra na cena.
		• Pode ser chamada de qualquer lugar.
		• Exemplo: TGDMouse.positionOnScene().

	2. positionOnScreen()
		• Retorna um vetor de 2 dimensões (Vector2) com a posição do mouse em relação ao que se encontra na UI (espaço visível na tela).
		• Pode ser chamada de qualquer lugar.
		• Exemplo: TGDMouse.positionOnScreen().

	3. isHittingObject()
		• Retorna true (bool) se o mouse está sobre um objeto.
		• Pode ser chamada de qualquer lugar.
		• Exemplo: TGDMouse.isHittingObject().


-TGDCamera:
	4. shake(float duration, float magnitude)
		• Treme a câmera passando os parâmetros de duração (duration) e a intensidade (magnitude).
		• Duração e magnitude do tremor devem ser valores positivos.
		• Pode ser chamada de qualquer lugar, desde que o Script TGDCamera seja componente da câmera principal.
		• Exemplo: TGDCamera.shake(1, 0.4f).


-TGDMath:
	5. random(float min, float max)
		• Retorna um número (float) aleatório passando um intervalo.
		• Pode ser chamada de qualquer lugar.
		• Exemplo: TGDMath.random(0, 10).

	6. randomVector(float minX, float maxX, float minY, float maxY)
		• Retorna um vetor de 2 dimensões (Vector2) de forma aleatória passando intervalos para cada dimensão.
		• Pode ser chamada de qualquer lugar.
		• Exemplo: TGDMath.randomVector(-10, 10, -20, 20).

	7. angleBetweenPlanes(Plane plane1, Plane plane2)
		• Retorna um ângulo (float), em graus, entre 2 planos em 2 dimensões.
		• Pode ser chamada de qualquer lugar.
		• Exemplo: TGDMath.angleBetweenPlanes(new Plane(new Vector3(10, 0, 0), 20), new Plane(new Vector3(0, 10, 0), 20)).

	8. rotateVector(Vector2 vector, float angle)
		• Aplica uma rotação em um vetor de 2 dimensões. Retorna o vetor (Vector2) rotacionado.
		• Ângulo de rotação deve ser especificado em graus.
		• Pode ser chamada de qualquer lugar.
		• Exemplo: TGDMath.rotateVector(new Vector2(10,0), 90).

	9. generateNormalizedVector()	
		• Retorna um vetor de 2 dimensões (Vector2) aletório normalizado.
		• Pode ser chamada de qualquer lugar.
		• Exemplo: TGDMath.generateNormalizedVector().


-TGDUi:
	10. displayText(string txt, float x, float y)
		• Faz um texto ser apresentado na tela, passando um vetor de 2 (duas) posições.
		• Se um texto for instanciado na mesma posição que outro, o anterior será removido. Isso possibilita o acompanhamento de variáveis em tempo real (se a função for chamada no método Update, 
		por exemplo, os textos não vão ficar se sobrepondo e prejudicando a leitura).
		• Pode ser chamada de qualquer lugar.
		• Exemplo: TGDUi.displayText("O nome dele é Chico", new Vector2(30, -30)).

-------------------------------------------------------