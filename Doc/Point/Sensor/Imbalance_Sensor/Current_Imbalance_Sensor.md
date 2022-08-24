[Point](../../Point.md) > [Sensor](../Sensor.md) > [Imbalance_Sensor](Imbalance_Sensor.md) > [Current_Imbalance_Sensor](#)
# Current_Imbalance_Sensor

**Display name:** Current Imbalance Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Current_Imbalance_Sensor;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
