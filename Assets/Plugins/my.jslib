mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
  },
          ShowAd: function() {
            ysdk.adv.showFullscreenAdv({
                callbacks: {
                    onOpen: function (wasShown) {
                        console.log('������� Fullscreen ���������.');
                    },
                    onClose: function (wasShown) {
                        console.log("������� Fullscreen ���������.");
                    },
                    onError: function (error) {
                        console.log("������ �� ������� Fullscreen.");
                    }
                }
            })
        },

         ShowAdVozgran: function() {
            ysdk.adv.showRewardedVideo({
                callbacks: {
                    onOpen: () => {
                        console.log('������� Rewarded ���������.');
                    },
                    onRewarded: () => {
                        console.log('������� Rewarded �����������, � ���������� ������� ������ �� ��������.');
                        myGameInstance.SendMessage('reclama', 'VoznagrPolych');
                    },
                    onClose: () => {
                        console.log('������� Rewarded ���������.');
                    },
                    onError: (e) => {
                        console.log('������ �� ������� Rewarded:');
                    }
                }
            })
        },


          GetLang: function() {
            var lang = ysdk.environment.i18n.lang;
            var bufferSize = lengthBytesUTF8(lang) + 1;
            var buffer = _malloc(bufferSize);
            stringToUTF8(lang, buffer, bufferSize);
            
            console.log(buffer);
            return buffer;
         },


         MsgVivod: function() {
            console.log('-----------VoznagrPolych-------------');
         }
});