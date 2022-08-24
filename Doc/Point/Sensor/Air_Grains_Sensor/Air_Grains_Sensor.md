[Point](../../Point.md) > [Sensor](../Sensor.md) > [Air_Grains_Sensor](#)
# Air_Grains_Sensor

**Display name:** Air Grains Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Grains_Sensor;1

---


## Child interfaces
* [Outside_Air_Grains_Sensor](Outside_Air_Grains_Sensor.md)
* [Return_Air_Grains_Sensor](Return_Air_Grains_Sensor.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
