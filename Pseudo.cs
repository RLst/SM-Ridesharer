Rideshare Pseudocode
----------------

Making obstacles move

Vec2 horizonPoint;
Vec2 horizonPlane;
Vec2[] spawnPoints;
Vec2[] scenicSpawnPoints;
float spawnDuration = 2;

bool spawn1 = false;
bool spawn2 = false;
bool spawn3 = false;
bool spawn4 = false;
//etc

float spawnDuration = 1f;

bool isGameStarted = false;
bool isPlaying = false;

void Update()
{
	HandleObstacleSpawning();
	HandleScenicObjectSpawning();

	HandleObjectMovement();

	HandleObjectDespawn();
}

void HandleObstacleSpawning()
{
	const chance = 4;
	if (random(10) > chance)
		return;

	Vec2 spawnPoint = spawnPoints[random[4]];

	foreach (var x in obstacles)
	{
		if (GetVisibilty(x) == false)
		{
			SetVisibility(x, true);
			x.position.TransitByTime(from: spawnPoint, to: endPos, duration: spawnDuration, interpolation: Interpolation.EaseIn, pingpong: false);
		}
	}
}

void HandleScenicObjectSpawning(Vec2 startPos)
{
	const chance = 3;
	if (random(10) > chance)
		return;

	Vec2 spawnPoint = scenicSpawnPoints[random[2]];

	foreach (var x in scenicObjects)
	{
		if (GetVisibility(x) == false)
		{
			SetVisibility(x, true);
			x.position = startPos;
		}
	}
}

// void HandleObjectMovement()
// {
// 	//Move towards the
// 	foreach (var x in obstacles)
// 	{
// 		if (GetVisibility(o) == false)
// 			return;

// 		x.positi
// 	}
// }

/// <summary>
/// Check if objects
/// </summary>
void HandleObjectDespawn()
{
	foreach (var o in obstacles)
	{
		if (GetVisibility(o) == true && o.position > horizonPlane.y)
		{
			SetVisibility(o, false);
		}
	}
}



//GAME STATES
//Game ready
isPlaying = false;
isGameStarted = false;

//Game start
isPlaying = true
isGameStarted = true;

//Game end
isPlaying = false;
isGameStarted = true;

//Game reset
isPlaying = false;
isGameStarted = false;

/// Gameloop
float timeSinceLastRespawn = 0;


void Start()
{
	ResetGame();
}

void ResetGame()
{
	gameSpeed = 0;
	timeSinceLastRespawn = 0;
	isPlaying = false;
	isGameStarted = false;
}

public void StartGame()
{
	isPlaying = true;
	isGameStarted = true;
}

void Update()
{
	if (!isPlaying)
		return;

	
}

public void EndGame()
{
	ShowDeathSequence();
	ShowScore();
}
