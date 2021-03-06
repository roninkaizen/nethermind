Networks
********

By default Nethermind launches with mainnet network configuration but you can sync any of the below networks by adding a command line switch::

    --config name_of_the_network

Network name can be any of the following

* mainnet
* rinkeby
* goerli
* ropsten
* stureby

Mainnet
^^^^^^^

This is the main public Ethereum network secured by the ethash PoW algorithm.

::

    Nethermind.Runner --config mainnet
    
* `MainNet Stats <https://ethstats.net/>`_

Görli (goerli)
^^^^^^^^^^^^^^

This is a Clique-PoA based testnet supported by all major clients. It has a 15 seconds delay between blocks that are sealed by Goerli validators.

::

    Nethermind.Runner --config goerli
    
* `Görli Stats <https://stats.goerli.net/>`_
* `Görli BlockScout <https://blockscout.com/eth/goerli//>`_
* `Görli Gitter <https://gitter.im/goerli/testnet>`_

Ropsten
^^^^^^^

This is a test network secured by ethash PoW algorithm which resembles mainnet most closely but is prone to hashrate-based attacks.

::

    Nethermind.Runner --config ropsten

Rinkeby
^^^^^^^

This is a Clique-PoA based testnet supported by Geth and Nethermind. It has a 15 seconds delay between blocks.

::

    Nethermind.Runner --config rinkeby

* `Rinkeby Page <https://www.rinkeby.io/#stats>`_


Stureby
^^^^^^^

This is a PoW-based testnet introduced to rapidly test all the transitions between different Ethereum releases - first 50000 blocks include transitions from Frontier all the way to Constantinople.

::

    Nethermind.Runner --config stureby

* `Stureby Stats <http://boot.stureby.ethdevops.io/>`_

Kovan
^^^^^

This is an Aura-PoA based testnet supported by Parity only.

* `Kovan Page <https://kovan-testnet.github.io/website/>`_




