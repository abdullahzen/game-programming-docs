# Github LFS Setup

Enable Github LFS in your github repository `Settings` tab, under `General` by checking the box: 
![image](https://user-images.githubusercontent.com/24836477/186764788-08e7d38b-c8bb-4798-adc5-7ab2b4ba17fc.png)


```
cd to_root_of_repo
```

```
git lfs install
```

```
git lfs track "myfolder/**"
git add .gitattributes
git commit -m "Adding .gitattributes to enable Github LFS"
git push
```

