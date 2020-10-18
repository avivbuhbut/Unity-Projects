using UnityEngine;

public class EnemyMove : Enemies
{

    //variables
    public int _moveSpeed;
    public int _attackDamage;
    public int _lifePoints;
    public float _attackRadius;

    //movement
    public float _followRadius;
    //end
    [SerializeField] Transform playerTransform;

    SpriteRenderer enemySR;

    void Start()
    {
        //get the player transform   
        playerTransform = GameObject.FindWithTag("Player").transform;
        //enemy animation and sprite renderer /

        enemySR = GetComponent<SpriteRenderer>();
        //set the variables
        setMoveSpeed(_moveSpeed);
        setAttackDamage(_attackDamage);
        setLifePoints(_lifePoints);
        setAttackRadius(_attackRadius);
        setFollowRadius(_followRadius);
    }

    // Update is called once per frame
    void Update()
    {
        if (checkFollowRadius(playerTransform.position.x, transform.position.x))
        {
            //if player in front of the enemies
            if (playerTransform.position.x < transform.position.x)
            {

                if (checkAttackRadius(playerTransform.position.x, transform.position.x))
                {
                    //for attack animation
        
                }
                else
                {
                    this.transform.position += new Vector3(-getMoveSpeed() * Time.deltaTime, 0f, 0f);
                    //for attack animation
             
                    enemySR.flipX = true;
                }

            }
            //if player is behind enemies
            else if (playerTransform.position.x > transform.position.x)
            {
                if (checkAttackRadius(playerTransform.position.x, transform.position.x))
                {
                    //for attack animation
                    
                }
                else
                {
                    this.transform.position += new Vector3(getMoveSpeed() * Time.deltaTime, 0f, 0f);
                    //for attack animation
           
                    //walk
                
                    enemySR.flipX = false;
                }


            }
        }
        else
        {
            
        }


    }
}