# Mentorama-Unity-Beginner

Curso: **Profissão Desenvolvedor de Games em Unity**<br/>
Módulo: **Unity Iniciante**<br/>
Versão do Unity: **2021.3.1f1**<br/>
Acessar os arquivos das atividades na pasta: **Files**

## Módulo 1

Primeira atividade do curso:<br/>
Ambientalizar-se na ferramenta unity: hierarquia, cena, layout.<br/>
[Arquivos da Atividade](https://github.com/AlanLee1/Mentorama-Unity-Beginner/tree/main/Files/Module1)

<img src="/Files/Module1/Game.PNG" alt="project"/>

## Módulo 2

Segunda atividade do curso:<br/>
Exportar um projeto level greybox: iluminação, prefab.<br/>
[Arquivos da Atividade](https://github.com/AlanLee1/Mentorama-Unity-Beginner/tree/main/Files/Module2)

<img src="/Files/Module2/Game.PNG" alt="project"/>

## Módulo 3

Terceira atividade do curso:<br/>
Implementar um código que realize o cálculo de quantidade de cédulas de um valor.<br/>
[Arquivos da Atividade](https://github.com/AlanLee1/Mentorama-Unity-Beginner/tree/main/Files/Module3)

<img src="/Files/Module3/Log.PNG" alt="project"/>

## Módulo 4

Quarta atividade do curso:<br/>
Exportar build com 3 funcionalidades:<br/>
- dropdown: resolução;<br/>
- checkbox: fullscreen;<br/>
- button: close apllication<br/>

[Arquivos da Atividade](https://github.com/AlanLee1/Mentorama-Unity-Beginner/tree/main/Files/Module4)

<img src="/Files/Module4/Game.PNG" alt="project"/>

## Módulo 5

Quinta atividade do curso:<br/>
- Adicionar perguntas com dificuldades diferentes;
- Pontuações diferentes;
- Powerup: pular pergunta, eliminar perguntas erradas;
- Melhorar visual;

[Arquivos da Atividade](https://github.com/AlanLee1/Mentorama-Unity-Beginner/tree/main/Files/Module5)

<img src="/Files/Module5/Game.PNG" alt="project"/>

Ajuda: queria ter deixado apenas as 3 opções: "easy","medium" e "hard", sem a opção de selecionar "dificuldade".<br/>
Para que quando Inicializa-se a scene, aparecesse com a dificuldade selecionada pela ultima vez.<br/>
Porem quando eu coloco "dropdown.GetComponent<Dropdown>().value = dificuldade;"(linha 15 - Dificuldade.cs) passando a dificuldade armazenada em cache, ele cria um looping infinito.<br/>
Teria alguma maneira de fazer deste modo?<br/>